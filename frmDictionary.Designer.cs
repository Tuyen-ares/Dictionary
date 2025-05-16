namespace Dictionary
{
    partial class frmDictionary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDictionary));
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            pictureBox5 = new PictureBox();
            label5 = new Label();
            richTextBoxdef = new RichTextBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            comboBoxpartofspeech = new ComboBox();
            labeltypeofword3 = new Label();
            label3 = new Label();
            label2 = new Label();
            rtxtantonym = new RichTextBox();
            rtxtsynonym = new RichTextBox();
            mdAudio = new AxWMPLib.AxWindowsMediaPlayer();
            t1_rtxtOutput = new RichTextBox();
            lblPhonetics = new Label();
            picbxAudio = new PictureBox();
            t1_txtKey = new TextBox();
            tabPage2 = new TabPage();
            mediatranslate = new AxWMPLib.AxWindowsMediaPlayer();
            mediaorigin = new AxWMPLib.AxWindowsMediaPlayer();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            rtxtResult = new RichTextBox();
            btnTranslate = new Button();
            t2_rtxtKey = new RichTextBox();
            t1_lblTo = new Label();
            t1_lblFrom = new Label();
            t2_lblSwap = new Label();
            t2_cbobxTo = new ComboBox();
            t2_cbobxFrom = new ComboBox();
            tabPage3 = new TabPage();
            rtxtlistword = new RichTextBox();
            button1 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mdAudio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picbxAudio).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mediatranslate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mediaorigin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(89, 19);
            label1.Name = "label1";
            label1.Size = new Size(408, 54);
            label1.TabIndex = 3;
            label1.Text = "TỪ ĐIỂN ANH - VIỆT";
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Appearance = TabAppearance.Buttons;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl1.ImeMode = ImeMode.NoControl;
            tabControl1.Location = new Point(0, 10);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(960, 730);
            tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(pictureBox5);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(richTextBoxdef);
            tabPage1.Controls.Add(pictureBox4);
            tabPage1.Controls.Add(pictureBox3);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(comboBoxpartofspeech);
            tabPage1.Controls.Add(labeltypeofword3);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(rtxtantonym);
            tabPage1.Controls.Add(rtxtsynonym);
            tabPage1.Controls.Add(mdAudio);
            tabPage1.Controls.Add(t1_rtxtOutput);
            tabPage1.Controls.Add(lblPhonetics);
            tabPage1.Controls.Add(picbxAudio);
            tabPage1.Controls.Add(t1_txtKey);
            tabPage1.Location = new Point(4, 49);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(952, 677);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Tra từ";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.images;
            pictureBox5.Location = new Point(886, 603);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(42, 38);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 41;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(517, 291);
            label5.Name = "label5";
            label5.Size = new Size(281, 38);
            label5.TabIndex = 39;
            label5.Text = "Định nghĩa và Ví Dụ";
            // 
            // richTextBoxdef
            // 
            richTextBoxdef.Location = new Point(517, 332);
            richTextBoxdef.Name = "richTextBoxdef";
            richTextBoxdef.Size = new Size(353, 309);
            richTextBoxdef.TabIndex = 38;
            richTextBoxdef.Text = "";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.images;
            pictureBox4.Location = new Point(424, 603);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(42, 38);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 35;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.images;
            pictureBox3.Location = new Point(424, 414);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(42, 38);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 34;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 114);
            label4.Name = "label4";
            label4.Size = new Size(114, 38);
            label4.TabIndex = 33;
            label4.Text = "Loại Từ";
            // 
            // comboBoxpartofspeech
            // 
            comboBoxpartofspeech.FormattingEnabled = true;
            comboBoxpartofspeech.Location = new Point(240, 107);
            comboBoxpartofspeech.Name = "comboBoxpartofspeech";
            comboBoxpartofspeech.Size = new Size(151, 45);
            comboBoxpartofspeech.TabIndex = 32;
            // 
            // labeltypeofword3
            // 
            labeltypeofword3.AutoSize = true;
            labeltypeofword3.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labeltypeofword3.ForeColor = Color.DarkOrange;
            labeltypeofword3.Location = new Point(311, 114);
            labeltypeofword3.Name = "labeltypeofword3";
            labeltypeofword3.Size = new Size(0, 38);
            labeltypeofword3.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 469);
            label3.Name = "label3";
            label3.Size = new Size(187, 38);
            label3.TabIndex = 29;
            label3.Text = "Từ trái nghĩa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 291);
            label2.Name = "label2";
            label2.Size = new Size(211, 38);
            label2.TabIndex = 28;
            label2.Text = "Từ đồng nghĩa";
            // 
            // rtxtantonym
            // 
            rtxtantonym.Location = new Point(40, 510);
            rtxtantonym.Name = "rtxtantonym";
            rtxtantonym.Size = new Size(362, 131);
            rtxtantonym.TabIndex = 27;
            rtxtantonym.Text = "";
            // 
            // rtxtsynonym
            // 
            rtxtsynonym.Location = new Point(39, 332);
            rtxtsynonym.Name = "rtxtsynonym";
            rtxtsynonym.Size = new Size(362, 120);
            rtxtsynonym.TabIndex = 26;
            rtxtsynonym.Text = "";
            // 
            // mdAudio
            // 
            mdAudio.Enabled = true;
            mdAudio.Location = new Point(886, 122);
            mdAudio.Name = "mdAudio";
            mdAudio.OcxState = (AxHost.State)resources.GetObject("mdAudio.OcxState");
            mdAudio.Size = new Size(35, 34);
            mdAudio.TabIndex = 14;
            mdAudio.Visible = false;
            // 
            // t1_rtxtOutput
            // 
            t1_rtxtOutput.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            t1_rtxtOutput.ForeColor = Color.BlueViolet;
            t1_rtxtOutput.Location = new Point(40, 181);
            t1_rtxtOutput.Name = "t1_rtxtOutput";
            t1_rtxtOutput.ReadOnly = true;
            t1_rtxtOutput.Size = new Size(361, 97);
            t1_rtxtOutput.TabIndex = 25;
            t1_rtxtOutput.Text = "";
            t1_rtxtOutput.TextChanged += t1_rtxtOutput_TextChanged;
            // 
            // lblPhonetics
            // 
            lblPhonetics.AutoSize = true;
            lblPhonetics.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPhonetics.ForeColor = Color.DarkTurquoise;
            lblPhonetics.Location = new Point(647, 114);
            lblPhonetics.Name = "lblPhonetics";
            lblPhonetics.Size = new Size(114, 38);
            lblPhonetics.TabIndex = 23;
            lblPhonetics.Text = "[Pro'sa]";
            // 
            // picbxAudio
            // 
            picbxAudio.Image = (Image)resources.GetObject("picbxAudio.Image");
            picbxAudio.Location = new Point(573, 114);
            picbxAudio.Name = "picbxAudio";
            picbxAudio.Size = new Size(43, 38);
            picbxAudio.SizeMode = PictureBoxSizeMode.Zoom;
            picbxAudio.TabIndex = 22;
            picbxAudio.TabStop = false;
            picbxAudio.Click += picbxAudio_Click;
            // 
            // t1_txtKey
            // 
            t1_txtKey.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            t1_txtKey.Location = new Point(39, 42);
            t1_txtKey.Name = "t1_txtKey";
            t1_txtKey.Size = new Size(469, 43);
            t1_txtKey.TabIndex = 14;
            t1_txtKey.KeyDown += t1_txtKey_KeyDown;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(mediatranslate);
            tabPage2.Controls.Add(mediaorigin);
            tabPage2.Controls.Add(pictureBox2);
            tabPage2.Controls.Add(pictureBox1);
            tabPage2.Controls.Add(rtxtResult);
            tabPage2.Controls.Add(btnTranslate);
            tabPage2.Controls.Add(t2_rtxtKey);
            tabPage2.Controls.Add(t1_lblTo);
            tabPage2.Controls.Add(t1_lblFrom);
            tabPage2.Controls.Add(t2_lblSwap);
            tabPage2.Controls.Add(t2_cbobxTo);
            tabPage2.Controls.Add(t2_cbobxFrom);
            tabPage2.Location = new Point(4, 49);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(952, 677);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Dịch văn bản";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // mediatranslate
            // 
            mediatranslate.Enabled = true;
            mediatranslate.Location = new Point(504, 555);
            mediatranslate.Name = "mediatranslate";
            mediatranslate.OcxState = (AxHost.State)resources.GetObject("mediatranslate.OcxState");
            mediatranslate.Size = new Size(35, 34);
            mediatranslate.TabIndex = 32;
            mediatranslate.Visible = false;
            // 
            // mediaorigin
            // 
            mediaorigin.Enabled = true;
            mediaorigin.Location = new Point(496, 257);
            mediaorigin.Name = "mediaorigin";
            mediaorigin.OcxState = (AxHost.State)resources.GetObject("mediaorigin.OcxState");
            mediaorigin.Size = new Size(35, 34);
            mediaorigin.TabIndex = 31;
            mediaorigin.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(496, 383);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 30;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(496, 152);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // rtxtResult
            // 
            rtxtResult.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtxtResult.ForeColor = Color.BlueViolet;
            rtxtResult.Location = new Point(53, 383);
            rtxtResult.Name = "rtxtResult";
            rtxtResult.Size = new Size(437, 206);
            rtxtResult.TabIndex = 28;
            rtxtResult.Text = "";
            rtxtResult.TextChanged += rtxtResult_TextChanged;
            // 
            // btnTranslate
            // 
            btnTranslate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnTranslate.FlatAppearance.BorderColor = Color.Blue;
            btnTranslate.ForeColor = Color.Blue;
            btnTranslate.Location = new Point(200, 310);
            btnTranslate.Name = "btnTranslate";
            btnTranslate.Size = new Size(156, 53);
            btnTranslate.TabIndex = 27;
            btnTranslate.Text = "Dịch";
            btnTranslate.UseVisualStyleBackColor = true;
            btnTranslate.Click += btnTranslate_Click;
            // 
            // t2_rtxtKey
            // 
            t2_rtxtKey.BorderStyle = BorderStyle.FixedSingle;
            t2_rtxtKey.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            t2_rtxtKey.Location = new Point(53, 152);
            t2_rtxtKey.Name = "t2_rtxtKey";
            t2_rtxtKey.Size = new Size(437, 139);
            t2_rtxtKey.TabIndex = 26;
            t2_rtxtKey.Text = "";
            // 
            // t1_lblTo
            // 
            t1_lblTo.AutoSize = true;
            t1_lblTo.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            t1_lblTo.Location = new Point(308, 25);
            t1_lblTo.Name = "t1_lblTo";
            t1_lblTo.Size = new Size(141, 38);
            t1_lblTo.TabIndex = 25;
            t1_lblTo.Text = "Dịch sang";
            // 
            // t1_lblFrom
            // 
            t1_lblFrom.AutoSize = true;
            t1_lblFrom.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            t1_lblFrom.Location = new Point(48, 25);
            t1_lblFrom.Name = "t1_lblFrom";
            t1_lblFrom.Size = new Size(108, 38);
            t1_lblFrom.TabIndex = 24;
            t1_lblFrom.Text = "Dịch từ";
            // 
            // t2_lblSwap
            // 
            t2_lblSwap.AutoSize = true;
            t2_lblSwap.Cursor = Cursors.Hand;
            t2_lblSwap.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            t2_lblSwap.Location = new Point(249, 69);
            t2_lblSwap.Name = "t2_lblSwap";
            t2_lblSwap.Size = new Size(43, 38);
            t2_lblSwap.TabIndex = 23;
            t2_lblSwap.Text = "⇄";
            t2_lblSwap.Click += t2_lblSwap_Click;
            // 
            // t2_cbobxTo
            // 
            t2_cbobxTo.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            t2_cbobxTo.FormattingEnabled = true;
            t2_cbobxTo.Location = new Point(308, 66);
            t2_cbobxTo.Name = "t2_cbobxTo";
            t2_cbobxTo.Size = new Size(182, 45);
            t2_cbobxTo.TabIndex = 22;
            // 
            // t2_cbobxFrom
            // 
            t2_cbobxFrom.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            t2_cbobxFrom.FormattingEnabled = true;
            t2_cbobxFrom.Location = new Point(48, 66);
            t2_cbobxFrom.Name = "t2_cbobxFrom";
            t2_cbobxFrom.Size = new Size(182, 45);
            t2_cbobxFrom.TabIndex = 21;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button1);
            tabPage3.Controls.Add(rtxtlistword);
            tabPage3.Location = new Point(4, 49);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(952, 677);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Lịch sử tìm kiếm";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // rtxtlistword
            // 
            rtxtlistword.Location = new Point(38, 34);
            rtxtlistword.Name = "rtxtlistword";
            rtxtlistword.Size = new Size(484, 533);
            rtxtlistword.TabIndex = 0;
            rtxtlistword.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(85, 594);
            button1.Name = "button1";
            button1.Size = new Size(108, 52);
            button1.TabIndex = 1;
            button1.Text = "Xóa";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmDictionary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            ClientSize = new Size(972, 768);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Name = "frmDictionary";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dictionary (Từ điển Anh - Việt)";
            Load += frmDictionary_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)mdAudio).EndInit();
            ((System.ComponentModel.ISupportInitialize)picbxAudio).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)mediatranslate).EndInit();
            ((System.ComponentModel.ISupportInitialize)mediaorigin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private AxWMPLib.AxWindowsMediaPlayer mdAudio;
        private TextBox t1_txtKey;
        private Label lblPhonetics;
        private RichTextBox t1_rtxtOutput;
        private RichTextBox rtxtResult;
        private Button btnTranslate;
        private RichTextBox t2_rtxtKey;
        private Label t1_lblTo;
        private Label t1_lblFrom;
        private Label t2_lblSwap;
        private ComboBox t2_cbobxTo;
        private ComboBox t2_cbobxFrom;
        private TabPage tabPage3;
        private PictureBox picbxAudio;
        private AxWMPLib.AxWindowsMediaPlayer mediatranslate;
        private AxWMPLib.AxWindowsMediaPlayer mediaorigin;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private RichTextBox rtxtlistword;
        private Label label2;
        private RichTextBox rtxtantonym;
        private RichTextBox rtxtsynonym;
        private Label label3;
        private Label labeltypeofword3;
        private Label label4;
        private ComboBox comboBoxpartofspeech;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label5;
        private RichTextBox richTextBoxdef;
        private PictureBox pictureBox5;
        private Button button1;
    }
}
