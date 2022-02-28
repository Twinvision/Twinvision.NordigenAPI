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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.Banks.Size = new System.Drawing.Size(234, 267);
            this.Banks.TabIndex = 0;
            this.Banks.UseCompatibleStateImageBehavior = false;
            this.Banks.View = System.Windows.Forms.View.Tile;
            this.Banks.SelectedIndexChanged += new System.EventHandler(this.Banks_SelectedIndexChanged);
            // 
            // BankImages
            // 
            this.BankImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.BankImages.ImageSize = new System.Drawing.Size(32, 32);
            this.BankImages.TransparentColor = System.Drawing.Color.Transparent;
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
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(252, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(366, 383);
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 407);
            this.Controls.Add(this.CountriesLabel);
            this.Controls.Add(this.SecretKeyLabel);
            this.Controls.Add(this.SecretIdLabel);
            this.Controls.Add(this.PropertyGrid);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ListBanks);
            this.Controls.Add(this.SecretKey);
            this.Controls.Add(this.SecretId);
            this.Controls.Add(this.Countries);
            this.Controls.Add(this.Banks);
            this.Name = "Main";
            this.Text = "Nordigen Transaction Browser";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
    }
}