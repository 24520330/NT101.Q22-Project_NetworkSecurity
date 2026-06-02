namespace RSA
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
            groupBox1 = new GroupBox();
            btnGeneratePrimes = new Button();
            label2 = new Label();
            label1 = new Label();
            txtQ = new TextBox();
            txtP = new TextBox();
            groupBox2 = new GroupBox();
            btnGenerateKeys = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtD = new TextBox();
            txtE = new TextBox();
            txtPhi = new TextBox();
            txtN = new TextBox();
            groupBox3 = new GroupBox();
            btnDecrypt = new Button();
            btnEncrypt = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            txtDecrypted = new TextBox();
            txtCipher = new TextBox();
            txtMessage = new TextBox();
            rtbSteps = new RichTextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGeneratePrimes);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtQ);
            groupBox1.Controls.Add(txtP);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(417, 93);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Khởi tạo số nguyên tố";
            // 
            // btnGeneratePrimes
            // 
            btnGeneratePrimes.Location = new Point(293, 18);
            btnGeneratePrimes.Name = "btnGeneratePrimes";
            btnGeneratePrimes.Size = new Size(116, 51);
            btnGeneratePrimes.TabIndex = 4;
            btnGeneratePrimes.Text = "random";
            btnGeneratePrimes.UseVisualStyleBackColor = true;
            btnGeneratePrimes.Click += btnGeneratePrimes_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 54);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 3;
            label2.Text = "Nhập Q";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 2;
            label1.Text = "Nhập P";
            // 
            // txtQ
            // 
            txtQ.Location = new Point(144, 47);
            txtQ.Name = "txtQ";
            txtQ.Size = new Size(143, 23);
            txtQ.TabIndex = 1;
            // 
            // txtP
            // 
            txtP.Location = new Point(144, 18);
            txtP.Name = "txtP";
            txtP.Size = new Size(143, 23);
            txtP.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnGenerateKeys);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtD);
            groupBox2.Controls.Add(txtE);
            groupBox2.Controls.Add(txtPhi);
            groupBox2.Controls.Add(txtN);
            groupBox2.Location = new Point(12, 111);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(417, 156);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Các bước tạo khóa";
            // 
            // btnGenerateKeys
            // 
            btnGenerateKeys.Location = new Point(293, 22);
            btnGenerateKeys.Name = "btnGenerateKeys";
            btnGenerateKeys.Size = new Size(116, 111);
            btnGenerateKeys.TabIndex = 8;
            btnGenerateKeys.Text = "Tính toán khóa";
            btnGenerateKeys.UseVisualStyleBackColor = true;
            btnGenerateKeys.Click += btnGenerateKeys_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 117);
            label6.Name = "label6";
            label6.Size = new Size(81, 15);
            label6.TabIndex = 7;
            label6.Text = "Khóa bí mật d";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 88);
            label5.Name = "label5";
            label5.Size = new Size(129, 15);
            label5.TabIndex = 6;
            label5.Text = "Nhập khóa công khai e";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 59);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 5;
            label4.Text = "Giá trị Phi(n)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 29);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 4;
            label3.Text = "Giá trị n";
            // 
            // txtD
            // 
            txtD.Location = new Point(144, 110);
            txtD.Name = "txtD";
            txtD.ReadOnly = true;
            txtD.Size = new Size(143, 23);
            txtD.TabIndex = 3;
            // 
            // txtE
            // 
            txtE.Location = new Point(144, 81);
            txtE.Name = "txtE";
            txtE.Size = new Size(143, 23);
            txtE.TabIndex = 2;
            // 
            // txtPhi
            // 
            txtPhi.Location = new Point(144, 52);
            txtPhi.Name = "txtPhi";
            txtPhi.ReadOnly = true;
            txtPhi.Size = new Size(143, 23);
            txtPhi.TabIndex = 1;
            // 
            // txtN
            // 
            txtN.Location = new Point(144, 22);
            txtN.Name = "txtN";
            txtN.ReadOnly = true;
            txtN.Size = new Size(143, 23);
            txtN.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnDecrypt);
            groupBox3.Controls.Add(btnEncrypt);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(txtDecrypted);
            groupBox3.Controls.Add(txtCipher);
            groupBox3.Controls.Add(txtMessage);
            groupBox3.Location = new Point(12, 273);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(417, 165);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Mã hóa và Giải mã";
            // 
            // btnDecrypt
            // 
            btnDecrypt.Location = new Point(293, 58);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(116, 40);
            btnDecrypt.TabIndex = 7;
            btnDecrypt.Text = "Giải mã";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // btnEncrypt
            // 
            btnEncrypt.Location = new Point(293, 17);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(116, 35);
            btnEncrypt.TabIndex = 6;
            btnEncrypt.Text = "Mã hóa";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 83);
            label9.Name = "label9";
            label9.Size = new Size(87, 15);
            label9.TabIndex = 5;
            label9.Text = "Sau khi giải mã";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 54);
            label8.Name = "label8";
            label8.Size = new Size(58, 15);
            label8.TabIndex = 4;
            label8.Text = "Bản mã C";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 25);
            label7.Name = "label7";
            label7.Size = new Size(87, 15);
            label7.TabIndex = 3;
            label7.Text = "Nhập bản rõ M";
            // 
            // txtDecrypted
            // 
            txtDecrypted.Location = new Point(144, 75);
            txtDecrypted.Name = "txtDecrypted";
            txtDecrypted.Size = new Size(143, 23);
            txtDecrypted.TabIndex = 2;
            // 
            // txtCipher
            // 
            txtCipher.Location = new Point(144, 46);
            txtCipher.Name = "txtCipher";
            txtCipher.Size = new Size(143, 23);
            txtCipher.TabIndex = 1;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(144, 17);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(143, 23);
            txtMessage.TabIndex = 0;
            // 
            // rtbSteps
            // 
            rtbSteps.Location = new Point(447, 12);
            rtbSteps.Name = "rtbSteps";
            rtbSteps.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtbSteps.Size = new Size(332, 377);
            rtbSteps.TabIndex = 3;
            rtbSteps.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtbSteps);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtQ;
        private TextBox txtP;
        private Button btnGeneratePrimes;
        private Label label2;
        private GroupBox groupBox2;
        private TextBox txtN;
        private Label label3;
        private TextBox txtD;
        private TextBox txtE;
        private TextBox txtPhi;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnGenerateKeys;
        private GroupBox groupBox3;
        private TextBox txtDecrypted;
        private TextBox txtCipher;
        private TextBox txtMessage;
        private Label label9;
        private Label label8;
        private Label label7;
        private Button btnDecrypt;
        private Button btnEncrypt;
        private RichTextBox rtbSteps;
    }
}
