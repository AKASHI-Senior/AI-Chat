namespace WinFormsApp4
{
    partial class MainChatControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            panel2 = new Panel();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            tableLayoutPanel4 = new TableLayoutPanel();
            button3 = new Button();
            label2 = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            textBox1 = new TextBox();
            button4 = new Button();
            tableLayoutPanel7 = new TableLayoutPanel();
            label3 = new Label();
            button5 = new Button();
            panel3 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(22, 9, 64);
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("Segoe UI", 26F);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1191, 680);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(32, 9, 64);
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.MaximumSize = new Size(400, 0);
            panel1.MinimumSize = new Size(300, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 674);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(35, 9, 64);
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(panel2, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0000076F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(300, 674);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Controls.Add(button1, 0, 1);
            tableLayoutPanel3.Controls.Add(button2, 2, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(294, 287);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 2);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 74);
            label1.TabIndex = 0;
            label1.Text = "T";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(30, 68, 217);
            tableLayoutPanel3.SetColumnSpan(button1, 3);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(20, 107);
            button1.Margin = new Padding(20);
            button1.Name = "button1";
            button1.Size = new Size(254, 40);
            button1.TabIndex = 1;
            button1.Text = "New Chat";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(30, 68, 217);
            button2.Dock = DockStyle.Right;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 2);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(223, 3);
            button2.Name = "button2";
            button2.Size = new Size(68, 68);
            button2.TabIndex = 2;
            button2.Text = "1";
            button2.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Controls.Add(radioButton2);
            panel2.Controls.Add(radioButton1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 296);
            panel2.Name = "panel2";
            panel2.Size = new Size(294, 287);
            panel2.TabIndex = 1;
            // 
            // radioButton2
            // 
            radioButton2.Appearance = Appearance.Button;
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.RoyalBlue;
            radioButton2.CheckAlign = ContentAlignment.TopLeft;
            radioButton2.Dock = DockStyle.Top;
            radioButton2.FlatAppearance.BorderSize = 0;
            radioButton2.FlatAppearance.CheckedBackColor = Color.FromArgb(192, 255, 255);
            radioButton2.FlatStyle = FlatStyle.Flat;
            radioButton2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            radioButton2.ForeColor = Color.White;
            radioButton2.Location = new Point(0, 31);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(294, 31);
            radioButton2.TabIndex = 2;
            radioButton2.Text = "survival";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            radioButton1.Appearance = Appearance.Button;
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.FromArgb(30, 68, 217);
            radioButton1.CheckAlign = ContentAlignment.TopLeft;
            radioButton1.Checked = true;
            radioButton1.Dock = DockStyle.Top;
            radioButton1.FlatAppearance.BorderSize = 0;
            radioButton1.FlatAppearance.CheckedBackColor = Color.FromArgb(30, 68, 217);
            radioButton1.FlatStyle = FlatStyle.Flat;
            radioButton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            radioButton1.ForeColor = Color.White;
            radioButton1.Location = new Point(0, 0);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(294, 31);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "Vpn";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.AutoSize = true;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(button3, 0, 0);
            tableLayoutPanel4.Controls.Add(label2, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 589);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(294, 82);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(30, 68, 217);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point, 2);
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(3, 3);
            button3.Name = "button3";
            button3.Size = new Size(75, 75);
            button3.TabIndex = 0;
            button3.Text = "Ы";
            button3.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(150, 0);
            label2.Name = "label2";
            label2.Size = new Size(141, 82);
            label2.TabIndex = 1;
            label2.Text = "User";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(tableLayoutPanel6, 0, 2);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel7, 0, 0);
            tableLayoutPanel5.Controls.Add(panel3, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Font = new Font("Segoe UI", 10F);
            tableLayoutPanel5.Location = new Point(309, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 3;
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100.000008F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.Size = new Size(879, 674);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.AutoSize = true;
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel6.Controls.Add(textBox1, 0, 0);
            tableLayoutPanel6.Controls.Add(button4, 1, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 642);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(873, 29);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Segoe UI", 9F);
            textBox1.Location = new Point(15, 3);
            textBox1.Margin = new Padding(15, 3, 15, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(814, 23);
            textBox1.TabIndex = 0;
            // 
            // button4
            // 
            button4.BackColor = Color.Gold;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 9F);
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(847, 3);
            button4.Name = "button4";
            button4.Size = new Size(23, 23);
            button4.TabIndex = 1;
            button4.Text = ">";
            button4.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 3;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel7.Controls.Add(label3, 0, 0);
            tableLayoutPanel7.Controls.Add(button5, 2, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 3);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(873, 100);
            tableLayoutPanel7.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 26F);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(134, 100);
            label3.TabIndex = 0;
            label3.Text = "Isma AI";
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button5.BackColor = Color.Red;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(795, 27);
            button5.Name = "button5";
            button5.Size = new Size(75, 45);
            button5.TabIndex = 1;
            button5.Text = "Delete";
            button5.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.AutoScroll = true;
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 109);
            panel3.Name = "panel3";
            panel3.Size = new Size(873, 527);
            panel3.TabIndex = 2;
            // 
            // MainChatControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(tableLayoutPanel1);
            Name = "MainChatControl";
            Size = new Size(1191, 680);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label1;
        private Button button1;
        private Button button2;
        private Panel panel2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private TableLayoutPanel tableLayoutPanel4;
        private Button button3;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private TextBox textBox1;
        private Button button4;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label3;
        private Button button5;
        private Panel panel3;
    }
}
