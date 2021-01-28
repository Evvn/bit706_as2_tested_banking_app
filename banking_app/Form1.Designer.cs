
namespace banking_app
{
    partial class Form1
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
            this.lstAccounts = new System.Windows.Forms.ListBox();
            this.customerName = new System.Windows.Forms.Label();
            this.txtOutputLabel = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.Label();
            this.btnGetInfo = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnAddInterest = new System.Windows.Forms.Button();
            this.numInput = new System.Windows.Forms.NumericUpDown();
            this.textHistory = new System.Windows.Forms.Label();
            this.lstHistory = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numInput)).BeginInit();
            this.SuspendLayout();
            // 
            // lstAccounts
            // 
            this.lstAccounts.FormattingEnabled = true;
            this.lstAccounts.ItemHeight = 20;
            this.lstAccounts.Location = new System.Drawing.Point(319, 64);
            this.lstAccounts.Name = "lstAccounts";
            this.lstAccounts.Size = new System.Drawing.Size(536, 104);
            this.lstAccounts.TabIndex = 0;
            // 
            // customerName
            // 
            this.customerName.AutoSize = true;
            this.customerName.Location = new System.Drawing.Point(315, 41);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(117, 20);
            this.customerName.TabIndex = 1;
            this.customerName.Text = "customerName";
            // 
            // txtOutputLabel
            // 
            this.txtOutputLabel.AutoSize = true;
            this.txtOutputLabel.Location = new System.Drawing.Point(35, 409);
            this.txtOutputLabel.Name = "txtOutputLabel";
            this.txtOutputLabel.Size = new System.Drawing.Size(62, 20);
            this.txtOutputLabel.TabIndex = 2;
            this.txtOutputLabel.Text = "Output:";
            // 
            // txtOutput
            // 
            this.txtOutput.AutoSize = true;
            this.txtOutput.Location = new System.Drawing.Point(35, 443);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(0, 20);
            this.txtOutput.TabIndex = 3;
            // 
            // btnGetInfo
            // 
            this.btnGetInfo.Location = new System.Drawing.Point(39, 37);
            this.btnGetInfo.Name = "btnGetInfo";
            this.btnGetInfo.Size = new System.Drawing.Size(228, 58);
            this.btnGetInfo.TabIndex = 4;
            this.btnGetInfo.Text = "Get info";
            this.btnGetInfo.UseVisualStyleBackColor = true;
            this.btnGetInfo.Click += new System.EventHandler(this.btnGetInfo_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(39, 110);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(228, 58);
            this.btnDeposit.TabIndex = 5;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(39, 184);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(228, 58);
            this.btnWithdraw.TabIndex = 6;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnAddInterest
            // 
            this.btnAddInterest.Location = new System.Drawing.Point(39, 260);
            this.btnAddInterest.Name = "btnAddInterest";
            this.btnAddInterest.Size = new System.Drawing.Size(228, 58);
            this.btnAddInterest.TabIndex = 7;
            this.btnAddInterest.Text = "Add interest";
            this.btnAddInterest.UseVisualStyleBackColor = true;
            this.btnAddInterest.Click += new System.EventHandler(this.btnAddInterest_Click);
            // 
            // numInput
            // 
            this.numInput.DecimalPlaces = 2;
            this.numInput.Location = new System.Drawing.Point(39, 362);
            this.numInput.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numInput.Name = "numInput";
            this.numInput.Size = new System.Drawing.Size(228, 26);
            this.numInput.TabIndex = 8;
            // 
            // textHistory
            // 
            this.textHistory.AutoSize = true;
            this.textHistory.Location = new System.Drawing.Point(319, 188);
            this.textHistory.Name = "textHistory";
            this.textHistory.Size = new System.Drawing.Size(58, 20);
            this.textHistory.TabIndex = 9;
            this.textHistory.Text = "History";
            // 
            // lstHistory
            // 
            this.lstHistory.FormattingEnabled = true;
            this.lstHistory.ItemHeight = 20;
            this.lstHistory.Location = new System.Drawing.Point(323, 211);
            this.lstHistory.Name = "lstHistory";
            this.lstHistory.Size = new System.Drawing.Size(532, 184);
            this.lstHistory.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 549);
            this.Controls.Add(this.lstHistory);
            this.Controls.Add(this.textHistory);
            this.Controls.Add(this.numInput);
            this.Controls.Add(this.btnAddInterest);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnGetInfo);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtOutputLabel);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.lstAccounts);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstAccounts;
        private System.Windows.Forms.Label customerName;
        private System.Windows.Forms.Label txtOutputLabel;
        private System.Windows.Forms.Label txtOutput;
        private System.Windows.Forms.Button btnGetInfo;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnAddInterest;
        private System.Windows.Forms.NumericUpDown numInput;
        private System.Windows.Forms.Label textHistory;
        private System.Windows.Forms.ListBox lstHistory;
    }
}

