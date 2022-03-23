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
            this.TransactionDetails = new System.Windows.Forms.DataGridView();
            this.PropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.SecretIdLabel = new System.Windows.Forms.Label();
            this.SecretKeyLabel = new System.Windows.Forms.Label();
            this.CountriesLabel = new System.Windows.Forms.Label();
            this.CreateEndUserAgreement = new System.Windows.Forms.Button();
            this.RequisitionId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.TabPageBrowser = new System.Windows.Forms.TabPage();
            this.TabPageTransactionDetails = new System.Windows.Forms.TabPage();
            this.AccountsLabel = new System.Windows.Forms.Label();
            this.Accounts = new System.Windows.Forms.ComboBox();
            this.ListAccounts = new System.Windows.Forms.Button();
            this.FromDate = new System.Windows.Forms.DateTimePicker();
            this.FromDateLabel = new System.Windows.Forms.Label();
            this.ToDate = new System.Windows.Forms.DateTimePicker();
            this.ToDateLabel = new System.Windows.Forms.Label();
            this.ListTransactionDetails = new System.Windows.Forms.Button();
            this.DeleteRequisition = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionDetails)).BeginInit();
            this.TabControl.SuspendLayout();
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
            this.Banks.Size = new System.Drawing.Size(234, 212);
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
            // TransactionDetails
            // 
            this.TransactionDetails.AllowUserToAddRows = false;
            this.TransactionDetails.AllowUserToDeleteRows = false;
            this.TransactionDetails.AllowUserToOrderColumns = true;
            this.TransactionDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TransactionDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransactionDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TransactionDetails.Location = new System.Drawing.Point(3, 3);
            this.TransactionDetails.Name = "TransactionDetails";
            this.TransactionDetails.RowTemplate.Height = 25;
            this.TransactionDetails.Size = new System.Drawing.Size(352, 528);
            this.TransactionDetails.TabIndex = 5;
            this.TransactionDetails.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.TransactionDetails_DataBindingComplete);
            this.TransactionDetails.SelectionChanged += new System.EventHandler(this.TransactionDetails_SelectionChanged);
            // 
            // PropertyGrid
            // 
            this.PropertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PropertyGrid.Location = new System.Drawing.Point(624, 12);
            this.PropertyGrid.Name = "PropertyGrid";
            this.PropertyGrid.Size = new System.Drawing.Size(164, 562);
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
            this.CreateEndUserAgreement.Location = new System.Drawing.Point(16, 346);
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
            this.RequisitionId.Location = new System.Drawing.Point(114, 375);
            this.RequisitionId.Name = "RequisitionId";
            this.RequisitionId.ReadOnly = true;
            this.RequisitionId.Size = new System.Drawing.Size(132, 23);
            this.RequisitionId.TabIndex = 3;
            this.RequisitionId.TextChanged += new System.EventHandler(this.RequisitionId_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Location = new System.Drawing.Point(12, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Requisition id:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TabControl
            // 
            this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl.Controls.Add(this.TabPageBrowser);
            this.TabControl.Controls.Add(this.TabPageTransactionDetails);
            this.TabControl.Location = new System.Drawing.Point(252, 12);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(366, 562);
            this.TabControl.TabIndex = 8;
            // 
            // TabPageBrowser
            // 
            this.TabPageBrowser.Location = new System.Drawing.Point(4, 24);
            this.TabPageBrowser.Name = "TabPageBrowser";
            this.TabPageBrowser.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageBrowser.Size = new System.Drawing.Size(358, 534);
            this.TabPageBrowser.TabIndex = 0;
            this.TabPageBrowser.Text = "Browser";
            this.TabPageBrowser.UseVisualStyleBackColor = true;
            // 
            // TabPageTransactionDetails
            // 
            this.TabPageTransactionDetails.Controls.Add(this.TransactionDetails);
            this.TabPageTransactionDetails.Location = new System.Drawing.Point(4, 24);
            this.TabPageTransactionDetails.Name = "TabPageTransactionDetails";
            this.TabPageTransactionDetails.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageTransactionDetails.Size = new System.Drawing.Size(358, 534);
            this.TabPageTransactionDetails.TabIndex = 1;
            this.TabPageTransactionDetails.Text = "Transaction details";
            this.TabPageTransactionDetails.UseVisualStyleBackColor = true;
            // 
            // AccountsLabel
            // 
            this.AccountsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AccountsLabel.Location = new System.Drawing.Point(16, 465);
            this.AccountsLabel.Name = "AccountsLabel";
            this.AccountsLabel.Size = new System.Drawing.Size(63, 15);
            this.AccountsLabel.TabIndex = 10;
            this.AccountsLabel.Text = "Accounts:";
            this.AccountsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Accounts
            // 
            this.Accounts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Accounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Accounts.FormattingEnabled = true;
            this.Accounts.Location = new System.Drawing.Point(89, 462);
            this.Accounts.Name = "Accounts";
            this.Accounts.Size = new System.Drawing.Size(161, 23);
            this.Accounts.TabIndex = 9;
            // 
            // ListAccounts
            // 
            this.ListAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ListAccounts.Location = new System.Drawing.Point(16, 433);
            this.ListAccounts.Name = "ListAccounts";
            this.ListAccounts.Size = new System.Drawing.Size(234, 23);
            this.ListAccounts.TabIndex = 11;
            this.ListAccounts.Text = "List accounts";
            this.ListAccounts.UseVisualStyleBackColor = true;
            this.ListAccounts.Click += new System.EventHandler(this.ListAccounts_Click);
            // 
            // FromDate
            // 
            this.FromDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FromDate.CustomFormat = "yyyy-MM-dd";
            this.FromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FromDate.Location = new System.Drawing.Point(89, 491);
            this.FromDate.Name = "FromDate";
            this.FromDate.Size = new System.Drawing.Size(161, 23);
            this.FromDate.TabIndex = 12;
            // 
            // FromDateLabel
            // 
            this.FromDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FromDateLabel.Location = new System.Drawing.Point(16, 497);
            this.FromDateLabel.Name = "FromDateLabel";
            this.FromDateLabel.Size = new System.Drawing.Size(63, 15);
            this.FromDateLabel.TabIndex = 13;
            this.FromDateLabel.Text = "From:";
            this.FromDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ToDate
            // 
            this.ToDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ToDate.CustomFormat = "yyyy-MM-dd";
            this.ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ToDate.Location = new System.Drawing.Point(89, 520);
            this.ToDate.Name = "ToDate";
            this.ToDate.Size = new System.Drawing.Size(161, 23);
            this.ToDate.TabIndex = 12;
            // 
            // ToDateLabel
            // 
            this.ToDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ToDateLabel.Location = new System.Drawing.Point(12, 526);
            this.ToDateLabel.Name = "ToDateLabel";
            this.ToDateLabel.Size = new System.Drawing.Size(63, 15);
            this.ToDateLabel.TabIndex = 13;
            this.ToDateLabel.Text = "To:";
            this.ToDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ListTransactionDetails
            // 
            this.ListTransactionDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ListTransactionDetails.Location = new System.Drawing.Point(16, 547);
            this.ListTransactionDetails.Name = "ListTransactionDetails";
            this.ListTransactionDetails.Size = new System.Drawing.Size(234, 23);
            this.ListTransactionDetails.TabIndex = 11;
            this.ListTransactionDetails.Text = "List transaction details";
            this.ListTransactionDetails.UseVisualStyleBackColor = true;
            this.ListTransactionDetails.Click += new System.EventHandler(this.ListTransactionDetails_Click);
            // 
            // DeleteRequisition
            // 
            this.DeleteRequisition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteRequisition.Location = new System.Drawing.Point(16, 404);
            this.DeleteRequisition.Name = "DeleteRequisition";
            this.DeleteRequisition.Size = new System.Drawing.Size(234, 23);
            this.DeleteRequisition.TabIndex = 11;
            this.DeleteRequisition.Text = "Delete active requisition";
            this.DeleteRequisition.UseVisualStyleBackColor = true;
            this.DeleteRequisition.Click += new System.EventHandler(this.DeleteRequisition_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 586);
            this.Controls.Add(this.ToDateLabel);
            this.Controls.Add(this.FromDateLabel);
            this.Controls.Add(this.ToDate);
            this.Controls.Add(this.FromDate);
            this.Controls.Add(this.ListTransactionDetails);
            this.Controls.Add(this.DeleteRequisition);
            this.Controls.Add(this.ListAccounts);
            this.Controls.Add(this.AccountsLabel);
            this.Controls.Add(this.Accounts);
            this.Controls.Add(this.TabControl);
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
            ((System.ComponentModel.ISupportInitialize)(this.TransactionDetails)).EndInit();
            this.TabControl.ResumeLayout(false);
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
        private DataGridView TransactionDetails;
        private PropertyGrid PropertyGrid;
        private Label SecretIdLabel;
        private Label SecretKeyLabel;
        private Label CountriesLabel;
        private Button CreateEndUserAgreement;
        private TextBox RequisitionId;
        private Label label1;
        private TabControl TabControl;
        private TabPage TabPageBrowser;
        private TabPage TabPageTransactionDetails;      
        private Label AccountsLabel;
        private ComboBox Accounts;
        private Button ListAccounts;
        private DateTimePicker FromDate;
        private Label FromDateLabel;
        private DateTimePicker ToDate;
        private Label ToDateLabel;
        private Button ListTransactionDetails;
        private Button DeleteRequisition;
    }
}