namespace Twinvision.Nordigen.WinformsTest
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Banks = new System.Windows.Forms.ListView();
            this.BankImages = new System.Windows.Forms.ImageList(this.components);
            this.Countries = new System.Windows.Forms.ComboBox();
            this.SecretId = new System.Windows.Forms.TextBox();
            this.SecretKey = new System.Windows.Forms.TextBox();
            this.ListBanks = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.SecretIdLabel = new System.Windows.Forms.Label();
            this.SecretKeyLabel = new System.Windows.Forms.Label();
            this.CountriesLabel = new System.Windows.Forms.Label();
            this.CreateEndUserAgreement = new System.Windows.Forms.Button();
            this.RequisitionId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabPageBrowser = new System.Windows.Forms.TabPage();
            this.WebViewContent = new System.Windows.Forms.PictureBox();
            this.TabPageTransactionDetails = new System.Windows.Forms.TabPage();
            this.WebView = new EO.WebBrowser.WebView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.TabPageBrowser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WebViewContent)).BeginInit();
            this.TabPageTransactionDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // Banks
            // 
            this.Banks.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.Banks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Banks.LargeImageList = this.BankImages;
            this.Banks.Location = new System.Drawing.Point(12, 128);
            this.Banks.Name = "Banks";
            this.Banks.Size = new System.Drawing.Size(234, 183);
            this.Banks.TabIndex = 0;
            this.Banks.UseCompatibleStateImageBehavior = false;
            this.Banks.View = System.Windows.Forms.View.Tile;
            this.Banks.SelectedIndexChanged += new System.EventHandler(this.Banks_SelectedIndexChanged);
            // 
            // BankImages
            // 
            this.BankImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.BankImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("BankImages.ImageStream")));
            this.BankImages.TransparentColor = System.Drawing.Color.Transparent;
            this.BankImages.Images.SetKeyName(0, "SandBoxBank");
            // 
            // Countries
            // 
            this.Countries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Countries.FormattingEnabled = true;
            this.Countries.Location = new System.Drawing.Point(85, 70);
            this.Countries.Name = "Countries";
            this.Countries.Size = new System.Drawing.Size(161, 23);
            this.Countries.TabIndex = 1;
            this.Countries.SelectedValueChanged += new System.EventHandler(this.Countries_SelectedValueChanged);
            // 
            // SecretId
            // 
            this.SecretId.Location = new System.Drawing.Point(85, 12);
            this.SecretId.Name = "SecretId";
            this.SecretId.Size = new System.Drawing.Size(161, 23);
            this.SecretId.TabIndex = 2;
            // 
            // SecretKey
            // 
            this.SecretKey.Location = new System.Drawing.Point(85, 41);
            this.SecretKey.Name = "SecretKey";
            this.SecretKey.Size = new System.Drawing.Size(161, 23);
            this.SecretKey.TabIndex = 3;
            // 
            // ListBanks
            // 
            this.ListBanks.Location = new System.Drawing.Point(12, 99);
            this.ListBanks.Name = "ListBanks";
            this.ListBanks.Size = new System.Drawing.Size(234, 23);
            this.ListBanks.TabIndex = 4;
            this.ListBanks.Text = "List banks";
            this.ListBanks.UseVisualStyleBackColor = true;
            this.ListBanks.Click += new System.EventHandler(this.ListBanks_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(352, 349);
            this.dataGridView1.TabIndex = 5;
            // 
            // PropertyGrid
            // 
            this.PropertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PropertyGrid.Location = new System.Drawing.Point(624, 12);
            this.PropertyGrid.Name = "PropertyGrid";
            this.PropertyGrid.Size = new System.Drawing.Size(164, 383);
            this.PropertyGrid.TabIndex = 6;
            // 
            // SecretIdLabel
            // 
            this.SecretIdLabel.Location = new System.Drawing.Point(12, 12);
            this.SecretIdLabel.Name = "SecretIdLabel";
            this.SecretIdLabel.Size = new System.Drawing.Size(63, 23);
            this.SecretIdLabel.TabIndex = 7;
            this.SecretIdLabel.Text = "Secret id:";
            this.SecretIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SecretKeyLabel
            // 
            this.SecretKeyLabel.Location = new System.Drawing.Point(12, 44);
            this.SecretKeyLabel.Name = "SecretKeyLabel";
            this.SecretKeyLabel.Size = new System.Drawing.Size(63, 15);
            this.SecretKeyLabel.TabIndex = 7;
            this.SecretKeyLabel.Text = "Secret key:";
            this.SecretKeyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CountriesLabel
            // 
            this.CountriesLabel.Location = new System.Drawing.Point(12, 73);
            this.CountriesLabel.Name = "CountriesLabel";
            this.CountriesLabel.Size = new System.Drawing.Size(63, 15);
            this.CountriesLabel.TabIndex = 7;
            this.CountriesLabel.Text = "Countries:";
            this.CountriesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CreateEndUserAgreement
            // 
            this.CreateEndUserAgreement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CreateEndUserAgreement.Location = new System.Drawing.Point(12, 317);
            this.CreateEndUserAgreement.Name = "CreateEndUserAgreement";
            this.CreateEndUserAgreement.Size = new System.Drawing.Size(234, 23);
            this.CreateEndUserAgreement.TabIndex = 4;
            this.CreateEndUserAgreement.Text = "Create agreement and requisition";
            this.CreateEndUserAgreement.UseVisualStyleBackColor = true;
            this.CreateEndUserAgreement.Click += new System.EventHandler(this.CreateEndUserAgreement_Click);
            // 
            // RequisitionId
            // 
            this.RequisitionId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RequisitionId.Location = new System.Drawing.Point(114, 346);
            this.RequisitionId.Name = "RequisitionId";
            this.RequisitionId.ReadOnly = true;
            this.RequisitionId.Size = new System.Drawing.Size(132, 23);
            this.RequisitionId.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Location = new System.Drawing.Point(12, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Requisition id:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.TabPageBrowser);
            this.tabControl1.Controls.Add(this.TabPageTransactionDetails);
            this.tabControl1.Location = new System.Drawing.Point(252, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(366, 383);
            this.tabControl1.TabIndex = 8;
            // 
            // TabPageBrowser
            // 
            this.TabPageBrowser.Controls.Add(this.WebViewContent);
            this.TabPageBrowser.Location = new System.Drawing.Point(4, 24);
            this.TabPageBrowser.Name = "TabPageBrowser";
            this.TabPageBrowser.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageBrowser.Size = new System.Drawing.Size(358, 355);
            this.TabPageBrowser.TabIndex = 0;
            this.TabPageBrowser.Text = "Browser";
            this.TabPageBrowser.UseVisualStyleBackColor = true;
            // 
            // WebViewContent
            // 
            this.WebViewContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebViewContent.Location = new System.Drawing.Point(3, 3);
            this.WebViewContent.Name = "WebViewContent";
            this.WebViewContent.Size = new System.Drawing.Size(352, 349);
            this.WebViewContent.TabIndex = 0;
            this.WebViewContent.TabStop = false;
            // 
            // TabPageTransactionDetails
            // 
            this.TabPageTransactionDetails.Controls.Add(this.dataGridView1);
            this.TabPageTransactionDetails.Location = new System.Drawing.Point(4, 24);
            this.TabPageTransactionDetails.Name = "TabPageTransactionDetails";
            this.TabPageTransactionDetails.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageTransactionDetails.Size = new System.Drawing.Size(358, 355);
            this.TabPageTransactionDetails.TabIndex = 1;
            this.TabPageTransactionDetails.Text = "Transaction details";
            this.TabPageTransactionDetails.UseVisualStyleBackColor = true;
            // 
            // WebView
            // 
            this.WebView.InputMsgFilter = null;
            this.WebView.ObjectForScripting = null;
            this.WebView.Title = null;
            this.WebView.Url = "https://www.twinvision.nl";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 407);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.CountriesLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SecretKeyLabel);
            this.Controls.Add(this.SecretIdLabel);
            this.Controls.Add(this.PropertyGrid);
            this.Controls.Add(this.CreateEndUserAgreement);
            this.Controls.Add(this.ListBanks);
            this.Controls.Add(this.RequisitionId);
            this.Controls.Add(this.SecretKey);
            this.Controls.Add(this.SecretId);
            this.Controls.Add(this.Countries);
            this.Controls.Add(this.Banks);
            this.Name = "Main";
            this.Text = "Nordigen Transaction Browser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.TabPageBrowser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WebViewContent)).EndInit();
            this.TabPageTransactionDetails.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView Banks;
        private ComboBox Countries;
        private TextBox SecretId;
        private TextBox SecretKey;
        private Button ListBanks;
        private ImageList BankImages;
        private DataGridView dataGridView1;
        private PropertyGrid PropertyGrid;
        private Label SecretIdLabel;
        private Label SecretKeyLabel;
        private Label CountriesLabel;
        private Button CreateEndUserAgreement;
        private TextBox RequisitionId;
        private Label label1;
        private TabControl tabControl1;
        private TabPage TabPageBrowser;
        private TabPage TabPageTransactionDetails;
        private EO.WebBrowser.WebView WebView;
        private PictureBox WebViewContent;
    }
}