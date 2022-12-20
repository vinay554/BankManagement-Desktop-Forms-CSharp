namespace BankingApplication
{
    partial class StaffDetails
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
            this.getStaffbutton = new System.Windows.Forms.Button();
            this.getStaffLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.branchTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // getStaffbutton
            // 
            this.getStaffbutton.Location = new System.Drawing.Point(63, 137);
            this.getStaffbutton.Name = "getStaffbutton";
            this.getStaffbutton.Size = new System.Drawing.Size(75, 23);
            this.getStaffbutton.TabIndex = 0;
            this.getStaffbutton.Text = "Get Staff";
            this.getStaffbutton.UseVisualStyleBackColor = true;
            this.getStaffbutton.Click += new System.EventHandler(this.getStaffbutton_Click);
            // 
            // getStaffLabel
            // 
            this.getStaffLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.getStaffLabel.Location = new System.Drawing.Point(63, 188);
            this.getStaffLabel.Name = "getStaffLabel";
            this.getStaffLabel.Size = new System.Drawing.Size(370, 125);
            this.getStaffLabel.TabIndex = 1;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(63, 353);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter the branch name(Kansas or Missouri)";
            // 
            // branchTextBox
            // 
            this.branchTextBox.Location = new System.Drawing.Point(364, 83);
            this.branchTextBox.Name = "branchTextBox";
            this.branchTextBox.Size = new System.Drawing.Size(100, 22);
            this.branchTextBox.TabIndex = 4;
            // 
            // StaffDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.branchTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.getStaffLabel);
            this.Controls.Add(this.getStaffbutton);
            this.Name = "StaffDetails";
            this.Text = "StaffDetails";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StaffDetails_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getStaffbutton;
        private System.Windows.Forms.Label getStaffLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox branchTextBox;
    }
}