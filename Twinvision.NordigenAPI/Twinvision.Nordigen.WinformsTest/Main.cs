using Twinvision.NordigenAPI;
using Twinvision.NordigenAPI.Responses;

namespace Twinvision.Nordigen.WinformsTest
{
    public partial class Main : Form
    {
        private HttpClient client = new HttpClient();
        private Dictionary<string, string> countries = new Dictionary<string, string>();

        private Institution[]? institutions = null;

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
            var nac = new NordigenAPICaller(SecretId.Text, SecretKey.Text);
            institutions = await nac.Institutions.GetInstitutions((string)Countries.SelectedValue);
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
        }

        private void Countries_SelectedValueChanged(object sender, EventArgs e)
        {
            ListBanks.Enabled = Countries.SelectedValue != null;
        }
    }
}