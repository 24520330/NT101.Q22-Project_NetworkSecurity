namespace Playfair
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
            tabContrlMatrx = new TabControl();
            tabPage1 = new TabPage();
            btnResult5 = new Button();
            btnCancel5 = new Button();
            btnProcessControl5 = new Button();
            label6 = new Label();
            tbPKey2 = new TextBox();
            tbPKey1 = new TextBox();
            tbBKey2 = new TextBox();
            tbBKey1 = new TextBox();
            btnCal5x5 = new Button();
            label1 = new Label();
            tbInput5x5 = new RichTextBox();
            cbOption5x5 = new ComboBox();
            tbOutput5x5 = new RichTextBox();
            tlpMatrix5x5 = new TableLayoutPanel();
            tbKey5x5 = new TextBox();
            label4 = new Label();
            panel1 = new Panel();
            tabPage2 = new TabPage();
            btnResult6 = new Button();
            btnCancel6 = new Button();
            btnProcessControl6 = new Button();
            label5 = new Label();
            tbPKey4 = new TextBox();
            tbPKey3 = new TextBox();
            tbBKey4 = new TextBox();
            tbBKey3 = new TextBox();
            btnCal6x6 = new Button();
            label3 = new Label();
            cbOption6x6 = new ComboBox();
            tlpMatrix6x6 = new TableLayoutPanel();
            label2 = new Label();
            tbKey6x6 = new TextBox();
            tbOutput6x6 = new RichTextBox();
            tbInput6x6 = new RichTextBox();
            panel2 = new Panel();
            tabContrlMatrx.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabContrlMatrx
            // 
            tabContrlMatrx.AccessibleName = "";
            tabContrlMatrx.Controls.Add(tabPage1);
            tabContrlMatrx.Controls.Add(tabPage2);
            tabContrlMatrx.Location = new Point(0, 1);
            tabContrlMatrx.Name = "tabContrlMatrx";
            tabContrlMatrx.SelectedIndex = 0;
            tabContrlMatrx.Size = new Size(912, 482);
            tabContrlMatrx.TabIndex = 10;
            tabContrlMatrx.Tag = "";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnResult5);
            tabPage1.Controls.Add(btnCancel5);
            tabPage1.Controls.Add(btnProcessControl5);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(tbPKey2);
            tabPage1.Controls.Add(tbPKey1);
            tabPage1.Controls.Add(tbBKey2);
            tabPage1.Controls.Add(tbBKey1);
            tabPage1.Controls.Add(btnCal5x5);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(tbInput5x5);
            tabPage1.Controls.Add(cbOption5x5);
            tabPage1.Controls.Add(tbOutput5x5);
            tabPage1.Controls.Add(tlpMatrix5x5);
            tabPage1.Controls.Add(tbKey5x5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(904, 449);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "5x5";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnResult5
            // 
            btnResult5.Location = new Point(635, 303);
            btnResult5.Name = "btnResult5";
            btnResult5.Size = new Size(255, 29);
            btnResult5.TabIndex = 49;
            btnResult5.Text = "Xem kết quả";
            btnResult5.UseVisualStyleBackColor = true;
            btnResult5.Click += btnResult5_Click;
            // 
            // btnCancel5
            // 
            btnCancel5.Location = new Point(635, 408);
            btnCancel5.Name = "btnCancel5";
            btnCancel5.Size = new Size(255, 29);
            btnCancel5.TabIndex = 48;
            btnCancel5.Text = "Hủy bỏ";
            btnCancel5.UseVisualStyleBackColor = true;
            btnCancel5.Click += btnCancel5_Click;
            // 
            // btnProcessControl5
            // 
            btnProcessControl5.Location = new Point(635, 373);
            btnProcessControl5.Name = "btnProcessControl5";
            btnProcessControl5.Size = new Size(255, 29);
            btnProcessControl5.TabIndex = 47;
            btnProcessControl5.Text = "Dừng/Tiếp tục";
            btnProcessControl5.UseVisualStyleBackColor = true;
            btnProcessControl5.Click += btnProcessControl5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(744, 252);
            label6.Name = "label6";
            label6.Size = new Size(37, 35);
            label6.TabIndex = 45;
            label6.Text = "→";
            // 
            // tbPKey2
            // 
            tbPKey2.Location = new Point(820, 260);
            tbPKey2.Name = "tbPKey2";
            tbPKey2.ReadOnly = true;
            tbPKey2.Size = new Size(27, 27);
            tbPKey2.TabIndex = 44;
            tbPKey2.TextAlign = HorizontalAlignment.Center;
            // 
            // tbPKey1
            // 
            tbPKey1.Location = new Point(787, 260);
            tbPKey1.Name = "tbPKey1";
            tbPKey1.ReadOnly = true;
            tbPKey1.Size = new Size(27, 27);
            tbPKey1.TabIndex = 43;
            tbPKey1.TextAlign = HorizontalAlignment.Center;
            // 
            // tbBKey2
            // 
            tbBKey2.Location = new Point(711, 261);
            tbBKey2.Name = "tbBKey2";
            tbBKey2.ReadOnly = true;
            tbBKey2.Size = new Size(27, 27);
            tbBKey2.TabIndex = 42;
            tbBKey2.TextAlign = HorizontalAlignment.Center;
            // 
            // tbBKey1
            // 
            tbBKey1.Location = new Point(678, 261);
            tbBKey1.Name = "tbBKey1";
            tbBKey1.ReadOnly = true;
            tbBKey1.Size = new Size(27, 27);
            tbBKey1.TabIndex = 41;
            tbBKey1.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCal5x5
            // 
            btnCal5x5.Location = new Point(635, 338);
            btnCal5x5.Name = "btnCal5x5";
            btnCal5x5.Size = new Size(255, 29);
            btnCal5x5.TabIndex = 40;
            btnCal5x5.Text = "Thực hiện từng bước";
            btnCal5x5.UseVisualStyleBackColor = true;
            btnCal5x5.Click += btnCal5x5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 209);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 39;
            label1.Text = "Bạn muốn";
            // 
            // tbInput5x5
            // 
            tbInput5x5.Location = new Point(8, 3);
            tbInput5x5.Name = "tbInput5x5";
            tbInput5x5.Size = new Size(591, 188);
            tbInput5x5.TabIndex = 34;
            tbInput5x5.Text = "";
            // 
            // cbOption5x5
            // 
            cbOption5x5.FormattingEnabled = true;
            cbOption5x5.Items.AddRange(new object[] { "MÃ HÓA", "GIẢI MÃ" });
            cbOption5x5.Location = new Point(84, 206);
            cbOption5x5.Name = "cbOption5x5";
            cbOption5x5.Size = new Size(114, 28);
            cbOption5x5.TabIndex = 33;
            // 
            // tbOutput5x5
            // 
            tbOutput5x5.Location = new Point(8, 252);
            tbOutput5x5.Name = "tbOutput5x5";
            tbOutput5x5.ReadOnly = true;
            tbOutput5x5.Size = new Size(591, 188);
            tbOutput5x5.TabIndex = 35;
            tbOutput5x5.Text = "";
            // 
            // tlpMatrix5x5
            // 
            tlpMatrix5x5.ColumnCount = 5;
            tlpMatrix5x5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tlpMatrix5x5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tlpMatrix5x5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tlpMatrix5x5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tlpMatrix5x5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tlpMatrix5x5.Location = new Point(635, 3);
            tlpMatrix5x5.Name = "tlpMatrix5x5";
            tlpMatrix5x5.RowCount = 5;
            tlpMatrix5x5.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tlpMatrix5x5.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tlpMatrix5x5.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tlpMatrix5x5.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tlpMatrix5x5.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tlpMatrix5x5.Size = new Size(255, 244);
            tlpMatrix5x5.TabIndex = 38;
            // 
            // tbKey5x5
            // 
            tbKey5x5.Location = new Point(304, 206);
            tbKey5x5.Name = "tbKey5x5";
            tbKey5x5.PlaceholderText = "Nhập khóa";
            tbKey5x5.Size = new Size(295, 27);
            tbKey5x5.TabIndex = 36;
            tbKey5x5.TextChanged += tbKey5x5_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(231, 209);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 37;
            label4.Text = "Keyword";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(627, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(271, 244);
            panel1.TabIndex = 46;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnResult6);
            tabPage2.Controls.Add(btnCancel6);
            tabPage2.Controls.Add(btnProcessControl6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(tbPKey4);
            tabPage2.Controls.Add(tbPKey3);
            tabPage2.Controls.Add(tbBKey4);
            tabPage2.Controls.Add(tbBKey3);
            tabPage2.Controls.Add(btnCal6x6);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(cbOption6x6);
            tabPage2.Controls.Add(tlpMatrix6x6);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(tbKey6x6);
            tabPage2.Controls.Add(tbOutput6x6);
            tabPage2.Controls.Add(tbInput6x6);
            tabPage2.Controls.Add(panel2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(904, 449);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "6x6";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnResult6
            // 
            btnResult6.Location = new Point(635, 303);
            btnResult6.Name = "btnResult6";
            btnResult6.Size = new Size(255, 29);
            btnResult6.TabIndex = 50;
            btnResult6.Text = "Xem kết quả";
            btnResult6.UseVisualStyleBackColor = true;
            btnResult6.Click += btnResult6_Click;
            // 
            // btnCancel6
            // 
            btnCancel6.Location = new Point(635, 408);
            btnCancel6.Name = "btnCancel6";
            btnCancel6.Size = new Size(255, 29);
            btnCancel6.TabIndex = 49;
            btnCancel6.Text = "Hủy bỏ";
            btnCancel6.UseVisualStyleBackColor = true;
            btnCancel6.Click += btnCancel6_Click;
            // 
            // btnProcessControl6
            // 
            btnProcessControl6.Location = new Point(635, 373);
            btnProcessControl6.Name = "btnProcessControl6";
            btnProcessControl6.Size = new Size(255, 29);
            btnProcessControl6.TabIndex = 48;
            btnProcessControl6.Text = "Dừng/Tiếp tục";
            btnProcessControl6.UseVisualStyleBackColor = true;
            btnProcessControl6.Click += btnProcessControl6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(744, 252);
            label5.Name = "label5";
            label5.Size = new Size(37, 35);
            label5.TabIndex = 38;
            label5.Text = "→";
            // 
            // tbPKey4
            // 
            tbPKey4.Location = new Point(820, 260);
            tbPKey4.Name = "tbPKey4";
            tbPKey4.ReadOnly = true;
            tbPKey4.Size = new Size(27, 27);
            tbPKey4.TabIndex = 37;
            tbPKey4.TextAlign = HorizontalAlignment.Center;
            // 
            // tbPKey3
            // 
            tbPKey3.Location = new Point(787, 260);
            tbPKey3.Name = "tbPKey3";
            tbPKey3.ReadOnly = true;
            tbPKey3.Size = new Size(27, 27);
            tbPKey3.TabIndex = 36;
            tbPKey3.TextAlign = HorizontalAlignment.Center;
            // 
            // tbBKey4
            // 
            tbBKey4.Location = new Point(711, 261);
            tbBKey4.Name = "tbBKey4";
            tbBKey4.ReadOnly = true;
            tbBKey4.Size = new Size(27, 27);
            tbBKey4.TabIndex = 35;
            tbBKey4.TextAlign = HorizontalAlignment.Center;
            // 
            // tbBKey3
            // 
            tbBKey3.Location = new Point(678, 261);
            tbBKey3.Name = "tbBKey3";
            tbBKey3.ReadOnly = true;
            tbBKey3.Size = new Size(27, 27);
            tbBKey3.TabIndex = 34;
            tbBKey3.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCal6x6
            // 
            btnCal6x6.Location = new Point(635, 338);
            btnCal6x6.Name = "btnCal6x6";
            btnCal6x6.Size = new Size(255, 29);
            btnCal6x6.TabIndex = 33;
            btnCal6x6.Text = "Thực hiện từng bước";
            btnCal6x6.UseVisualStyleBackColor = true;
            btnCal6x6.Click += btnCal6x6_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 209);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 32;
            label3.Text = "Bạn muốn";
            // 
            // cbOption6x6
            // 
            cbOption6x6.FormattingEnabled = true;
            cbOption6x6.Items.AddRange(new object[] { "MÃ HÓA", "GIẢI MÃ" });
            cbOption6x6.Location = new Point(84, 206);
            cbOption6x6.Name = "cbOption6x6";
            cbOption6x6.Size = new Size(114, 28);
            cbOption6x6.TabIndex = 24;
            // 
            // tlpMatrix6x6
            // 
            tlpMatrix6x6.ColumnCount = 6;
            tlpMatrix6x6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tlpMatrix6x6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tlpMatrix6x6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tlpMatrix6x6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tlpMatrix6x6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tlpMatrix6x6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tlpMatrix6x6.Location = new Point(635, 3);
            tlpMatrix6x6.Name = "tlpMatrix6x6";
            tlpMatrix6x6.RowCount = 6;
            tlpMatrix6x6.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tlpMatrix6x6.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tlpMatrix6x6.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tlpMatrix6x6.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tlpMatrix6x6.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tlpMatrix6x6.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tlpMatrix6x6.Size = new Size(255, 244);
            tlpMatrix6x6.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(231, 209);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 28;
            label2.Text = "Keyword";
            // 
            // tbKey6x6
            // 
            tbKey6x6.Location = new Point(304, 206);
            tbKey6x6.Name = "tbKey6x6";
            tbKey6x6.PlaceholderText = "Nhập khóa";
            tbKey6x6.Size = new Size(295, 27);
            tbKey6x6.TabIndex = 27;
            tbKey6x6.TextChanged += tbKey6x6_TextChanged;
            // 
            // tbOutput6x6
            // 
            tbOutput6x6.Location = new Point(8, 252);
            tbOutput6x6.Name = "tbOutput6x6";
            tbOutput6x6.ReadOnly = true;
            tbOutput6x6.Size = new Size(591, 188);
            tbOutput6x6.TabIndex = 26;
            tbOutput6x6.Text = "";
            // 
            // tbInput6x6
            // 
            tbInput6x6.Location = new Point(8, 3);
            tbInput6x6.Name = "tbInput6x6";
            tbInput6x6.Size = new Size(591, 188);
            tbInput6x6.TabIndex = 25;
            tbInput6x6.Text = "";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(627, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(271, 244);
            panel2.TabIndex = 47;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 479);
            Controls.Add(tabContrlMatrx);
            Name = "Form1";
            Text = "Playfair Cipher";
            Load += Form1_Load;
            tabContrlMatrx.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabContrlMatrx;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ComboBox cbOption6x6;
        private TableLayoutPanel tlpMatrix6x6;
        private Label label2;
        private TextBox tbKey6x6;
        private RichTextBox tbOutput6x6;
        private RichTextBox tbInput6x6;
        private Label label3;
        private Label label1;
        private RichTextBox tbInput5x5;
        private ComboBox cbOption5x5;
        private RichTextBox tbOutput5x5;
        private TableLayoutPanel tlpMatrix5x5;
        private TextBox tbKey5x5;
        private Label label4;
        private Button btnCal5x5;
        private Button btnCal6x6;
        private TextBox tbPKey4;
        private TextBox tbPKey3;
        private TextBox tbBKey4;
        private TextBox tbBKey3;
        private Label label6;
        private TextBox tbPKey2;
        private TextBox tbPKey1;
        private TextBox tbBKey2;
        private TextBox tbBKey1;
        private Label label5;
        private Panel panel1;
        private Panel panel2;
        private Button btnProcessControl5;
        private Button btnProcessControl6;
        private Button btnCancel5;
        private Button btnCancel6;
        private Button btnResult6;
        private Button btnResult5;
    }
}
