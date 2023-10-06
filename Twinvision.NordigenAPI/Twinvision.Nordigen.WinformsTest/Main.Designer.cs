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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            Banks = new ListView();
            BankImages = new ImageList(components);
            Countries = new ComboBox();
            SecretId = new TextBox();
            SecretKey = new TextBox();
            ListBanks = new Button();
            TransactionDetails = new DataGridView();
            PropertyGrid = new PropertyGrid();
            SecretIdLabel = new Label();
            SecretKeyLabel = new Label();
            CountriesLabel = new Label();
            CreateEndUserAgreement = new Button();
            RequisitionId = new TextBox();
            label1 = new Label();
            TabControl = new TabControl();
            TabPageBrowser = new TabPage();
            TabPageTransactionDetails = new TabPage();
            AccountsLabel = new Label();
            Accounts = new ComboBox();
            ListAccounts = new Button();
            FromDate = new DateTimePicker();
            FromDateLabel = new Label();
            ToDate = new DateTimePicker();
            ToDateLabel = new Label();
            ListTransactionDetails = new Button();
            DeleteRequisition = new Button();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)TransactionDetails).BeginInit();
            TabControl.SuspendLayout();
            TabPageTransactionDetails.SuspendLayout();
            SuspendLayout();
            // 
            // Banks
            // 
            Banks.Activation = ItemActivation.OneClick;
            Banks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            Banks.LargeImageList = BankImages;
            Banks.Location = new Point(12, 128);
            Banks.Name = "Banks";
            Banks.Size = new Size(234, 194);
            Banks.TabIndex = 0;
            Banks.UseCompatibleStateImageBehavior = false;
            Banks.View = View.Tile;
            Banks.SelectedIndexChanged += Banks_SelectedIndexChanged;
            // 
            // BankImages
            // 
            BankImages.ColorDepth = ColorDepth.Depth32Bit;
            BankImages.ImageStream = (ImageListStreamer)resources.GetObject("BankImages.ImageStream");
            BankImages.TransparentColor = Color.Transparent;
            BankImages.Images.SetKeyName(0, "SandBoxBank");
            // 
            // Countries
            // 
            Countries.DropDownStyle = ComboBoxStyle.DropDownList;
            Countries.FormattingEnabled = true;
            Countries.Location = new Point(85, 70);
            Countries.Name = "Countries";
            Countries.Size = new Size(161, 23);
            Countries.TabIndex = 1;
            Countries.SelectedValueChanged += Countries_SelectedValueChanged;
            // 
            // SecretId
            // 
            SecretId.Location = new Point(85, 12);
            SecretId.Name = "SecretId";
            SecretId.Size = new Size(161, 23);
            SecretId.TabIndex = 2;
            // 
            // SecretKey
            // 
            SecretKey.Location = new Point(85, 41);
            SecretKey.Name = "SecretKey";
            SecretKey.Size = new Size(161, 23);
            SecretKey.TabIndex = 3;
            // 
            // ListBanks
            // 
            ListBanks.Location = new Point(12, 99);
            ListBanks.Name = "ListBanks";
            ListBanks.Size = new Size(234, 23);
            ListBanks.TabIndex = 4;
            ListBanks.Text = "List banks";
            ListBanks.UseVisualStyleBackColor = true;
            ListBanks.Click += ListBanks_Click;
            // 
            // TransactionDetails
            // 
            TransactionDetails.AllowUserToAddRows = false;
            TransactionDetails.AllowUserToDeleteRows = false;
            TransactionDetails.AllowUserToOrderColumns = true;
            TransactionDetails.BorderStyle = BorderStyle.None;
            TransactionDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TransactionDetails.Dock = DockStyle.Fill;
            TransactionDetails.Location = new Point(3, 3);
            TransactionDetails.Name = "TransactionDetails";
            TransactionDetails.RowTemplate.Height = 25;
            TransactionDetails.Size = new Size(352, 580);
            TransactionDetails.TabIndex = 5;
            TransactionDetails.DataBindingComplete += TransactionDetails_DataBindingComplete;
            TransactionDetails.SelectionChanged += TransactionDetails_SelectionChanged;
            // 
            // PropertyGrid
            // 
            PropertyGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            PropertyGrid.Location = new Point(624, 12);
            PropertyGrid.Name = "PropertyGrid";
            PropertyGrid.Size = new Size(164, 614);
            PropertyGrid.TabIndex = 6;
            // 
            // SecretIdLabel
            // 
            SecretIdLabel.Location = new Point(12, 12);
            SecretIdLabel.Name = "SecretIdLabel";
            SecretIdLabel.Size = new Size(63, 23);
            SecretIdLabel.TabIndex = 7;
            SecretIdLabel.Text = "Secret id:";
            SecretIdLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // SecretKeyLabel
            // 
            SecretKeyLabel.Location = new Point(12, 44);
            SecretKeyLabel.Name = "SecretKeyLabel";
            SecretKeyLabel.Size = new Size(63, 15);
            SecretKeyLabel.TabIndex = 7;
            SecretKeyLabel.Text = "Secret key:";
            SecretKeyLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CountriesLabel
            // 
            CountriesLabel.Location = new Point(12, 73);
            CountriesLabel.Name = "CountriesLabel";
            CountriesLabel.Size = new Size(63, 15);
            CountriesLabel.TabIndex = 7;
            CountriesLabel.Text = "Countries:";
            CountriesLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CreateEndUserAgreement
            // 
            CreateEndUserAgreement.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CreateEndUserAgreement.Location = new Point(16, 357);
            CreateEndUserAgreement.Name = "CreateEndUserAgreement";
            CreateEndUserAgreement.Size = new Size(234, 23);
            CreateEndUserAgreement.TabIndex = 4;
            CreateEndUserAgreement.Text = "Create agreement and requisition";
            CreateEndUserAgreement.UseVisualStyleBackColor = true;
            CreateEndUserAgreement.Click += CreateEndUserAgreement_Click;
            // 
            // RequisitionId
            // 
            RequisitionId.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RequisitionId.Location = new Point(114, 386);
            RequisitionId.Name = "RequisitionId";
            RequisitionId.Size = new Size(132, 23);
            RequisitionId.TabIndex = 3;
            RequisitionId.TextChanged += RequisitionId_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.Location = new Point(12, 389);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 7;
            label1.Text = "Requisition id:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TabControl
            // 
            TabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TabControl.Controls.Add(TabPageBrowser);
            TabControl.Controls.Add(TabPageTransactionDetails);
            TabControl.Location = new Point(252, 12);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(366, 614);
            TabControl.TabIndex = 8;
            // 
            // TabPageBrowser
            // 
            TabPageBrowser.Location = new Point(4, 24);
            TabPageBrowser.Name = "TabPageBrowser";
            TabPageBrowser.Padding = new Padding(3);
            TabPageBrowser.Size = new Size(358, 586);
            TabPageBrowser.TabIndex = 0;
            TabPageBrowser.Text = "Browser";
            TabPageBrowser.UseVisualStyleBackColor = true;
            // 
            // TabPageTransactionDetails
            // 
            TabPageTransactionDetails.Controls.Add(TransactionDetails);
            TabPageTransactionDetails.Location = new Point(4, 24);
            TabPageTransactionDetails.Name = "TabPageTransactionDetails";
            TabPageTransactionDetails.Padding = new Padding(3);
            TabPageTransactionDetails.Size = new Size(358, 586);
            TabPageTransactionDetails.TabIndex = 1;
            TabPageTransactionDetails.Text = "Transaction details";
            TabPageTransactionDetails.UseVisualStyleBackColor = true;
            // 
            // AccountsLabel
            // 
            AccountsLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AccountsLabel.Location = new Point(16, 476);
            AccountsLabel.Name = "AccountsLabel";
            AccountsLabel.Size = new Size(63, 15);
            AccountsLabel.TabIndex = 10;
            AccountsLabel.Text = "Accounts:";
            AccountsLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Accounts
            // 
            Accounts.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Accounts.DropDownStyle = ComboBoxStyle.DropDownList;
            Accounts.FormattingEnabled = true;
            Accounts.Location = new Point(89, 473);
            Accounts.Name = "Accounts";
            Accounts.Size = new Size(161, 23);
            Accounts.TabIndex = 9;
            // 
            // ListAccounts
            // 
            ListAccounts.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ListAccounts.Location = new Point(16, 444);
            ListAccounts.Name = "ListAccounts";
            ListAccounts.Size = new Size(234, 23);
            ListAccounts.TabIndex = 11;
            ListAccounts.Text = "List accounts";
            ListAccounts.UseVisualStyleBackColor = true;
            ListAccounts.Click += ListAccounts_Click;
            // 
            // FromDate
            // 
            FromDate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            FromDate.CustomFormat = "yyyy-MM-dd";
            FromDate.Format = DateTimePickerFormat.Custom;
            FromDate.Location = new Point(89, 502);
            FromDate.Name = "FromDate";
            FromDate.Size = new Size(161, 23);
            FromDate.TabIndex = 12;
            // 
            // FromDateLabel
            // 
            FromDateLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            FromDateLabel.Location = new Point(16, 508);
            FromDateLabel.Name = "FromDateLabel";
            FromDateLabel.Size = new Size(63, 15);
            FromDateLabel.TabIndex = 13;
            FromDateLabel.Text = "From:";
            FromDateLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ToDate
            // 
            ToDate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ToDate.CustomFormat = "yyyy-MM-dd";
            ToDate.Format = DateTimePickerFormat.Custom;
            ToDate.Location = new Point(89, 531);
            ToDate.Name = "ToDate";
            ToDate.Size = new Size(161, 23);
            ToDate.TabIndex = 12;
            // 
            // ToDateLabel
            // 
            ToDateLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ToDateLabel.Location = new Point(12, 537);
            ToDateLabel.Name = "ToDateLabel";
            ToDateLabel.Size = new Size(63, 15);
            ToDateLabel.TabIndex = 13;
            ToDateLabel.Text = "To:";
            ToDateLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ListTransactionDetails
            // 
            ListTransactionDetails.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ListTransactionDetails.Location = new Point(16, 558);
            ListTransactionDetails.Name = "ListTransactionDetails";
            ListTransactionDetails.Size = new Size(234, 23);
            ListTransactionDetails.TabIndex = 11;
            ListTransactionDetails.Text = "List transaction details";
            ListTransactionDetails.UseVisualStyleBackColor = true;
            ListTransactionDetails.Click += ListTransactionDetails_Click;
            // 
            // DeleteRequisition
            // 
            DeleteRequisition.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            DeleteRequisition.Location = new Point(16, 415);
            DeleteRequisition.Name = "DeleteRequisition";
            DeleteRequisition.Size = new Size(234, 23);
            DeleteRequisition.TabIndex = 11;
            DeleteRequisition.Text = "Delete active requisition";
            DeleteRequisition.UseVisualStyleBackColor = true;
            DeleteRequisition.Click += DeleteRequisition_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.Location = new Point(12, 328);
            button1.Name = "button1";
            button1.Size = new Size(234, 23);
            button1.TabIndex = 14;
            button1.Text = "List accounts";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.Location = new Point(16, 603);
            button2.Name = "button2";
            button2.Size = new Size(234, 23);
            button2.TabIndex = 15;
            button2.Text = "Update Bank in EstateVision";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 638);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(ToDateLabel);
            Controls.Add(FromDateLabel);
            Controls.Add(ToDate);
            Controls.Add(FromDate);
            Controls.Add(ListTransactionDetails);
            Controls.Add(DeleteRequisition);
            Controls.Add(ListAccounts);
            Controls.Add(AccountsLabel);
            Controls.Add(Accounts);
            Controls.Add(TabControl);
            Controls.Add(CountriesLabel);
            Controls.Add(label1);
            Controls.Add(SecretKeyLabel);
            Controls.Add(SecretIdLabel);
            Controls.Add(PropertyGrid);
            Controls.Add(CreateEndUserAgreement);
            Controls.Add(ListBanks);
            Controls.Add(RequisitionId);
            Controls.Add(SecretKey);
            Controls.Add(SecretId);
            Controls.Add(Countries);
            Controls.Add(Banks);
            Name = "Main";
            Text = "Nordigen Transaction Browser";
            FormClosing += Main_FormClosing;
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)TransactionDetails).EndInit();
            TabControl.ResumeLayout(false);
            TabPageTransactionDetails.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
        private Button button1;
        private Button button2;
    }
}