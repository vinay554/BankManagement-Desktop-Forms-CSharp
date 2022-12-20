namespace BankingApplication
{
    partial class InterestDetails
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
            this.fixedDepositButton = new System.Windows.Forms.Button();
            this.currentAccountButton = new System.Windows.Forms.Button();
            this.advanceSavingsbutton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fixedDepositButton
            // 
            this.fixedDepositButton.Location = new System.Drawing.Point(70, 82);
            this.fixedDepositButton.Name = "fixedDepositButton";
            this.fixedDepositButton.Size = new System.Drawing.Size(160, 23);
            this.fixedDepositButton.TabIndex = 0;
            this.fixedDepositButton.Text = "Fixed Deposit Account";
            this.fixedDepositButton.UseVisualStyleBackColor = true;
            this.fixedDepositButton.Click += new System.EventHandler(this.fixedDepositButton_Click);
            // 
            // currentAccountButton
            // 
            this.currentAccountButton.Location = new System.Drawing.Point(70, 174);
            this.currentAccountButton.Name = "currentAccountButton";
            this.currentAccountButton.Size = new System.Drawing.Size(160, 23);
            this.currentAccountButton.TabIndex = 1;
            this.currentAccountButton.Text = "Current Account";
            this.currentAccountButton.UseVisualStyleBackColor = true;
            this.currentAccountButton.Click += new System.EventHandler(this.currentAccountButton_Click);
            // 
            // advanceSavingsbutton
            // 
            this.advanceSavingsbutton.Location = new System.Drawing.Point(70, 267);
            this.advanceSavingsbutton.Name = "advanceSavingsbutton";
            this.advanceSavingsbutton.Size = new System.Drawing.Size(160, 23);
            this.advanceSavingsbutton.TabIndex = 2;
            this.advanceSavingsbutton.Text = "Advance Savings Account";
            this.advanceSavingsbutton.UseVisualStyleBackColor = true;
            this.advanceSavingsbutton.Click += new System.EventHandler(this.advanceSavingsbutton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultLabel.Location = new System.Drawing.Point(347, 70);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(351, 281);
            this.resultLabel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select a specified button to get intetest details";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(73, 394);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // InterestDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.advanceSavingsbutton);
            this.Controls.Add(this.currentAccountButton);
            this.Controls.Add(this.fixedDepositButton);
            this.Name = "InterestDetails";
            this.Text = "InterestDetails";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InterestDetails_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fixedDepositButton;
        private System.Windows.Forms.Button currentAccountButton;
        private System.Windows.Forms.Button advanceSavingsbutton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitButton;
    }
}