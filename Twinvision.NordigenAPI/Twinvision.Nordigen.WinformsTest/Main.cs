using Twinvision.NordigenAPI;
using Twinvision.NordigenAPI.Responses;
using System.Linq;
using Twinvision.NordigenAPI.Requests;

namespace Twinvision.Nordigen.WinformsTest
{
    public partial class Main : Form
    {
        private HttpClient client = new HttpClient();
        private Dictionary<string, string> countries = new Dictionary<string, string>();

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
            if(nac == null)
            {
                return;
            }
            var agreementRequest = new AgreementRequest()
            {
                AccessScope = new[] { "balances", "details", "transactions" },
                AccessValidForDays = "30",
                InstitutionId = (string)Banks.SelectedItems[0].Tag,
                MaxHistoricalDays = "180"
            };
            var agreement = await nac.Agreements.CreateAgreement(agreementRequest);
            if (agreement == null)
            {
                return;
            }
            var requisitionRequest = new RequisitionRequest()
            {
                InstitutionId = agreement.InstitutionId,
                Agreement = agreement.Id,
                Redirect = "https://www.twinvision.nl",               
                Reference = "noref",
                UserLanguage = "NL",
                AccountSelection = false
            };
            var requisition = await nac.Requisitions.CreateRequisition(requisitionRequest);
            WebView.Url = requisition.Link;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            WebView.Create(WebViewContent.Handle);
        }
    }
}