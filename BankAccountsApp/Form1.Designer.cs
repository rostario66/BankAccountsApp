namespace BankAccountsApp
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            OwnerTxt = new TextBox();
            AmountNum = new NumericUpDown();
            BankAccountsGrid = new DataGridView();
            DepositButton = new Button();
            WithdrawButton = new Button();
            CreateAccountButton = new Button();
            InterestRateNum = new NumericUpDown();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)AmountNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BankAccountsGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InterestRateNum).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 54);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(99, 38);
            label1.TabIndex = 0;
            label1.Text = "Owner";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 368);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(116, 38);
            label2.TabIndex = 1;
            label2.Text = "Amount";
            // 
            // OwnerTxt
            // 
            OwnerTxt.Location = new Point(146, 54);
            OwnerTxt.Name = "OwnerTxt";
            OwnerTxt.Size = new Size(217, 43);
            OwnerTxt.TabIndex = 2;
            // 
            // AmountNum
            // 
            AmountNum.Location = new Point(146, 368);
            AmountNum.Margin = new Padding(137, 126, 137, 126);
            AmountNum.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            AmountNum.Minimum = new decimal(new int[] { 276447231, 23283, 0, int.MinValue });
            AmountNum.Name = "AmountNum";
            AmountNum.Size = new Size(196, 43);
            AmountNum.TabIndex = 3;
            // 
            // BankAccountsGrid
            // 
            BankAccountsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BankAccountsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BankAccountsGrid.Location = new Point(381, 54);
            BankAccountsGrid.Name = "BankAccountsGrid";
            BankAccountsGrid.RowHeadersWidth = 51;
            BankAccountsGrid.Size = new Size(354, 296);
            BankAccountsGrid.TabIndex = 4;
            // 
            // DepositButton
            // 
            DepositButton.Location = new Point(381, 363);
            DepositButton.Name = "DepositButton";
            DepositButton.Size = new Size(169, 53);
            DepositButton.TabIndex = 5;
            DepositButton.Text = "Deposit";
            DepositButton.UseVisualStyleBackColor = true;
            DepositButton.Click += DepositButton_Click;
            // 
            // WithdrawButton
            // 
            WithdrawButton.Location = new Point(556, 363);
            WithdrawButton.Name = "WithdrawButton";
            WithdrawButton.Size = new Size(179, 53);
            WithdrawButton.TabIndex = 7;
            WithdrawButton.Text = "Withdraw";
            WithdrawButton.UseVisualStyleBackColor = true;
            WithdrawButton.Click += WithdrawButton_Click;
            // 
            // CreateAccountButton
            // 
            CreateAccountButton.Location = new Point(35, 189);
            CreateAccountButton.Name = "CreateAccountButton";
            CreateAccountButton.Size = new Size(328, 50);
            CreateAccountButton.TabIndex = 8;
            CreateAccountButton.Text = "CreateAccount";
            CreateAccountButton.UseVisualStyleBackColor = true;
            CreateAccountButton.Click += CreateAccountButton_Click;
            // 
            // InterestRateNum
            // 
            InterestRateNum.Location = new Point(216, 109);
            InterestRateNum.Margin = new Padding(137, 126, 137, 126);
            InterestRateNum.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            InterestRateNum.Minimum = new decimal(new int[] { 276447231, 23283, 0, int.MinValue });
            InterestRateNum.Name = "InterestRateNum";
            InterestRateNum.Size = new Size(147, 43);
            InterestRateNum.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 111);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(213, 38);
            label3.TabIndex = 10;
            label3.Text = "Interest rate (%)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 475);
            Controls.Add(label3);
            Controls.Add(InterestRateNum);
            Controls.Add(CreateAccountButton);
            Controls.Add(WithdrawButton);
            Controls.Add(DepositButton);
            Controls.Add(BankAccountsGrid);
            Controls.Add(AmountNum);
            Controls.Add(OwnerTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)AmountNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)BankAccountsGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)InterestRateNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox OwnerTxt;
        private NumericUpDown AmountNum;
        private DataGridView BankAccountsGrid;
        private Button DepositButton;
        private Button WithdrawButton;
        private Button CreateAccountButton;
        private NumericUpDown InterestRateNum;
        private Label label3;
    }
}
