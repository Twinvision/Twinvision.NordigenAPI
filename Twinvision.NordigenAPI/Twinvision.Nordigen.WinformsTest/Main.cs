using Twinvision.NordigenAPI;
using Twinvision.NordigenAPI.Responses;
using System.Linq;
using Twinvision.NordigenAPI.Requests;
using System.ComponentModel;

namespace Twinvision.Nordigen.WinformsTest
{
    public partial class Main : Form
    {
        private HttpClient client = new HttpClient();
        private Dictionary<string, string> countries = new Dictionary<string, string>();
        private Dictionary<string, string> accounts = new Dictionary<string, string>();

        private List<Institution> institutions = new List<Institution>();

        private NordigenAPICaller? nac = null;

        public Main()
        {
            InitializeComponent();

            countries.Add("nl", "The Netherlands");
            countries.Add("be", "Belgium");
            countries.Add("de", "Germany");
            Countries.DataSource = countries.ToList();
            Countries.ValueMember = "Key";
            Countries.DisplayMember = "Value";

            FromDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).AddMonths(-1);
            ToDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).AddDays(-1);

        }

        private async void ListBanks_Click(object sender, EventArgs e)
        {
            Banks.Clear();
            nac = new NordigenAPICaller(SecretId.Text, SecretKey.Text);
            institutions = (await nac.Institutions.GetInstitutions((string)Countries.SelectedValue)).ToList();
            institutions.Insert(0, new Institution() { Id = "SANDBOXFINANCE_SFIN0000", Logo = "SandBoxBank", Name = "Sandbox Finance" });
            Banks.SuspendLayout();
            foreach (var institution in institutions)
            {
                if (!BankImages.Images.ContainsKey(institution.Logo))
                {
                    var imageData = await client.GetByteArrayAsync(institution.Logo);
                    using (var ms = new MemoryStream(imageData))
                    {
                        var bitmap = Image.FromStream(ms);
                        BankImages.Images.Add(institution.Logo, bitmap);
                    }
                }
                var lvi = new ListViewItem(institution.Name, institution.Logo)
                {
                    Tag = institution.Id
                };
                Banks.Items.Add(lvi);
            }
            Banks.ResumeLayout();
        }

        private void Banks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Banks.SelectedItems.Count > 0)
            {
                PropertyGrid.SelectedObject = institutions?.FirstOrDefault(where => where.Id == (string)Banks.SelectedItems[0].Tag);
            }
            else
            {
                PropertyGrid.SelectedObject = null;
            }
            CreateEndUserAgreement.Enabled = Banks.SelectedItems.Count > 0;
        }

        private void Countries_SelectedValueChanged(object sender, EventArgs e)
        {
            ListBanks.Enabled = Countries.SelectedValue != null;
        }

        private async void CreateEndUserAgreement_Click(object sender, EventArgs e)
        {
            Requisition? requisition = null;
            var institutionId = (string)Banks.SelectedItems[0].Tag;

            if (nac == null)
            {
                return;
            }
            //var agreementRequest = new AgreementRequest()
            //{
            //    AccessScope = new[] { "balances", "details", "transactions" },
            //    AccessValidForDays = 30,
            //    InstitutionId = (string)Banks.SelectedItems[0].Tag,
            //    MaxHistoricalDays = 180
            //};
            //var agreement = await nac.Agreements.CreateAgreement(agreementRequest);
            //if (agreement == null)
            //{
            //    return;
            //}

            var requisitions = await nac.Requisitions.GetRequisitions();

            if (requisitions.Results.FirstOrDefault(r => r.InstitutionId == institutionId) == null)
            {
                var requisitionRequest = new RequisitionRequest()
                {
                    InstitutionId = institutionId,
                    //Agreement = agreement.Id,
                    Redirect = "https://www.twinvision.nl",
                    Reference = Guid.NewGuid().ToString(),
                    UserLanguage = "NL",
                    AccountSelection = false
                };
                requisition = await nac.Requisitions.CreateRequisition(requisitionRequest);
            }
            else
            {
                requisition = requisitions.Results[0];
            }
            RequisitionId.Text = requisition.Id.ToString();
            WebView.Url = requisition.Link;
            await LoadAccounts();
        }

        private async Task LoadAccounts()
        {
            accounts.Clear();
            if(nac == null)
            {
                nac = new NordigenAPICaller(SecretId.Text, SecretKey.Text);
            }
            if(String.IsNullOrWhiteSpace(RequisitionId.Text))
            {
                return;
            }
            var requisitionAccounts = await nac.Requisitions.GetRequisition(Guid.Parse(RequisitionId.Text));
            foreach (var accountId in requisitionAccounts.Accounts)
            {
                var account = await nac.Accounts.GetAcountMetaData(accountId);
                accounts.Add(accountId, account.Iban);
            }
            Accounts.DataSource = accounts.ToList();
            Accounts.ValueMember = "Key";
            Accounts.DisplayMember = "Value";
        }

        private async void Main_Load(object sender, EventArgs e)
        {
            WebView.Create(WebViewContent.Handle);
            SecretId.Text = Properties.Settings.Default.SecretId;
            SecretKey.Text = Properties.Settings.Default.SecretKey;
            RequisitionId.Text = Properties.Settings.Default.RequisitionId;
            await LoadAccounts();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.SecretId = SecretId.Text;
            Properties.Settings.Default.SecretKey = SecretKey.Text;
            Properties.Settings.Default.RequisitionId = RequisitionId.Text;
            Properties.Settings.Default.Save();
        }

        private void RequisitionId_TextChanged(object sender, EventArgs e)
        {
            Accounts.Enabled = !String.IsNullOrWhiteSpace(RequisitionId.Text);
        }

        private async void ListAccounts_Click(object sender, EventArgs e)
        {
            await LoadAccounts();
        }

        private async void ListTransactionDetails_Click(object sender, EventArgs e)
        {
            if (nac == null)
            {
                nac = new NordigenAPICaller(SecretId.Text, SecretKey.Text);
            }
            var transactions = await nac.Accounts.GetAccountTransactions(Accounts.SelectedValue.ToString());
            TransactionDetails.DataSource = transactions.Transactions.Booked;
            TabControl.SelectedTab = TabPageTransactionDetails;

            var result = nac.Accounts.GetAccountBalances(Accounts.SelectedValue.ToString());
        }

        private void TransactionDetails_SelectionChanged(object sender, EventArgs e)
        {
            if(TransactionDetails.SelectedCells.Count > 0)
            {
                PropertyGrid.SelectedObject = TransactionDetails.SelectedCells[0].Value;
            } else
            {
                PropertyGrid.SelectedObject = null;
            }
        }

        private void TransactionDetails_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //TransactionDetails.Sort(TransactionDetails.Columns["BookingDate"], System.ComponentModel.ListSortDirection.Ascending);
        }
    }
}