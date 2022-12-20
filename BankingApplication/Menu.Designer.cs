namespace BankingApplication
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.generalBankingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newAccountOpeningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateSearchAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withdrawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fundTransferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bankToBankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currencyConvertorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interestDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resourcesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalBankingToolStripMenuItem,
            this.customerSearchToolStripMenuItem,
            this.fundTransferToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.resourcesToolStripMenuItem,
            this.staffDetailsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(988, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // generalBankingToolStripMenuItem
            // 
            this.generalBankingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newAccountOpeningToolStripMenuItem,
            this.updateSearchAccountToolStripMenuItem,
            this.allCustomersToolStripMenuItem});
            this.generalBankingToolStripMenuItem.Name = "generalBankingToolStripMenuItem";
            this.generalBankingToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.generalBankingToolStripMenuItem.Text = "Account";
            this.generalBankingToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // newAccountOpeningToolStripMenuItem
            // 
            this.newAccountOpeningToolStripMenuItem.Name = "newAccountOpeningToolStripMenuItem";
            this.newAccountOpeningToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.newAccountOpeningToolStripMenuItem.Text = "New Account opening";
            this.newAccountOpeningToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.newAccountOpeningToolStripMenuItem.Click += new System.EventHandler(this.newAccountOpeningToolStripMenuItem_Click);
            // 
            // updateSearchAccountToolStripMenuItem
            // 
            this.updateSearchAccountToolStripMenuItem.Name = "updateSearchAccountToolStripMenuItem";
            this.updateSearchAccountToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.updateSearchAccountToolStripMenuItem.Text = "Update Account";
            this.updateSearchAccountToolStripMenuItem.Click += new System.EventHandler(this.updateSearchAccountToolStripMenuItem_Click);
            // 
            // allCustomersToolStripMenuItem
            // 
            this.allCustomersToolStripMenuItem.Name = "allCustomersToolStripMenuItem";
            this.allCustomersToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.allCustomersToolStripMenuItem.Text = "All Customers";
            this.allCustomersToolStripMenuItem.Click += new System.EventHandler(this.allCustomersToolStripMenuItem_Click);
            // 
            // customerSearchToolStripMenuItem
            // 
            this.customerSearchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.depositToolStripMenuItem,
            this.withdrawToolStripMenuItem,
            this.transferToolStripMenuItem});
            this.customerSearchToolStripMenuItem.Name = "customerSearchToolStripMenuItem";
            this.customerSearchToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.customerSearchToolStripMenuItem.Text = "Transactions";
            this.customerSearchToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // depositToolStripMenuItem
            // 
            this.depositToolStripMenuItem.Name = "depositToolStripMenuItem";
            this.depositToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.depositToolStripMenuItem.Text = "Deposit";
            this.depositToolStripMenuItem.Click += new System.EventHandler(this.depositToolStripMenuItem_Click);
            // 
            // withdrawToolStripMenuItem
            // 
            this.withdrawToolStripMenuItem.Name = "withdrawToolStripMenuItem";
            this.withdrawToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.withdrawToolStripMenuItem.Text = "Withdraw";
            this.withdrawToolStripMenuItem.Click += new System.EventHandler(this.withdrawToolStripMenuItem_Click);
            // 
            // transferToolStripMenuItem
            // 
            this.transferToolStripMenuItem.Name = "transferToolStripMenuItem";
            this.transferToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.transferToolStripMenuItem.Text = "Transfer";
            this.transferToolStripMenuItem.Click += new System.EventHandler(this.transferToolStripMenuItem_Click);
            // 
            // fundTransferToolStripMenuItem
            // 
            this.fundTransferToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bankToBankToolStripMenuItem});
            this.fundTransferToolStripMenuItem.Name = "fundTransferToolStripMenuItem";
            this.fundTransferToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.fundTransferToolStripMenuItem.Text = "View";
            this.fundTransferToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // bankToBankToolStripMenuItem
            // 
            this.bankToBankToolStripMenuItem.Name = "bankToBankToolStripMenuItem";
            this.bankToBankToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.bankToBankToolStripMenuItem.Text = "View Balance";
            this.bankToBankToolStripMenuItem.Click += new System.EventHandler(this.bankToBankToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currencyConvertorToolStripMenuItem,
            this.interestDetailsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.helpToolStripMenuItem.Text = "Tools";
            this.helpToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // currencyConvertorToolStripMenuItem
            // 
            this.currencyConvertorToolStripMenuItem.Name = "currencyConvertorToolStripMenuItem";
            this.currencyConvertorToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.currencyConvertorToolStripMenuItem.Text = "Currency Convertor";
            this.currencyConvertorToolStripMenuItem.Click += new System.EventHandler(this.currencyConvertorToolStripMenuItem_Click);
            // 
            // interestDetailsToolStripMenuItem
            // 
            this.interestDetailsToolStripMenuItem.Name = "interestDetailsToolStripMenuItem";
            this.interestDetailsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.interestDetailsToolStripMenuItem.Text = "Interest Details";
            this.interestDetailsToolStripMenuItem.Click += new System.EventHandler(this.interestDetailsToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.toolsToolStripMenuItem.Text = "Other Transactions";
            this.toolsToolStripMenuItem.Click += new System.EventHandler(this.toolsToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // resourcesToolStripMenuItem
            // 
            this.resourcesToolStripMenuItem.Name = "resourcesToolStripMenuItem";
            this.resourcesToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.resourcesToolStripMenuItem.Text = "About";
            this.resourcesToolStripMenuItem.Click += new System.EventHandler(this.resourcesToolStripMenuItem_Click);
            // 
            // staffDetailsToolStripMenuItem
            // 
            this.staffDetailsToolStripMenuItem.Name = "staffDetailsToolStripMenuItem";
            this.staffDetailsToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.staffDetailsToolStripMenuItem.Text = "Staff Details";
            this.staffDetailsToolStripMenuItem.Click += new System.EventHandler(this.staffDetailsToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 564);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Menu";
            this.Text = "Banking Application";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem generalBankingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newAccountOpeningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fundTransferToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bankToBankToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateSearchAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depositToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withdrawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resourcesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currencyConvertorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interestDetailsToolStripMenuItem;
    }
}