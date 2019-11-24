namespace ADayAtTheRace
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AI_TextBox = new System.Windows.Forms.TextBox();
            this.Bob_TextBox = new System.Windows.Forms.TextBox();
            this.Joe_TextBox = new System.Windows.Forms.TextBox();
            this.AI_RadioButton = new System.Windows.Forms.RadioButton();
            this.Joe_RadioButton = new System.Windows.Forms.RadioButton();
            this.Bob_RadioButton = new System.Windows.Forms.RadioButton();
            this.Dog_Number_ComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Bucks_ComboBox = new System.Windows.Forms.ComboBox();
            this.GuyName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Race_Button = new System.Windows.Forms.Button();
            this.Bets_Button = new System.Windows.Forms.Button();
            this.Dog3_Pic = new System.Windows.Forms.PictureBox();
            this.Dog2_Pic = new System.Windows.Forms.PictureBox();
            this.Dog1_Pic = new System.Windows.Forms.PictureBox();
            this.Dog0_Pic = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dog3_Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog2_Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog1_Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog0_Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.AI_TextBox);
            this.groupBox3.Controls.Add(this.Bob_TextBox);
            this.groupBox3.Controls.Add(this.Joe_TextBox);
            this.groupBox3.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.Location = new System.Drawing.Point(167, 22);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(230, 114);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Circumstance";
            // 
            // AI_TextBox
            // 
            this.AI_TextBox.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AI_TextBox.Location = new System.Drawing.Point(15, 80);
            this.AI_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AI_TextBox.Name = "AI_TextBox";
            this.AI_TextBox.Size = new System.Drawing.Size(202, 21);
            this.AI_TextBox.TabIndex = 2;
            this.AI_TextBox.Text = "AI 돈 걸 준비하시고~";
            // 
            // Bob_TextBox
            // 
            this.Bob_TextBox.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Bob_TextBox.Location = new System.Drawing.Point(15, 51);
            this.Bob_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bob_TextBox.Name = "Bob_TextBox";
            this.Bob_TextBox.Size = new System.Drawing.Size(202, 21);
            this.Bob_TextBox.TabIndex = 1;
            this.Bob_TextBox.Text = "Bob 돈 걸 준비하시고~";
            // 
            // Joe_TextBox
            // 
            this.Joe_TextBox.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Joe_TextBox.Location = new System.Drawing.Point(15, 22);
            this.Joe_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Joe_TextBox.Name = "Joe_TextBox";
            this.Joe_TextBox.Size = new System.Drawing.Size(202, 21);
            this.Joe_TextBox.TabIndex = 0;
            this.Joe_TextBox.Text = "Joe 돈 걸 준비하시고~";
            // 
            // AI_RadioButton
            // 
            this.AI_RadioButton.AutoSize = true;
            this.AI_RadioButton.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AI_RadioButton.Location = new System.Drawing.Point(14, 81);
            this.AI_RadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AI_RadioButton.Name = "AI_RadioButton";
            this.AI_RadioButton.Size = new System.Drawing.Size(34, 16);
            this.AI_RadioButton.TabIndex = 10;
            this.AI_RadioButton.Text = "AI";
            this.AI_RadioButton.UseVisualStyleBackColor = true;
            this.AI_RadioButton.CheckedChanged += new System.EventHandler(this.AI_RadioButton_CheckedChanged);
            // 
            // Joe_RadioButton
            // 
            this.Joe_RadioButton.AutoSize = true;
            this.Joe_RadioButton.Checked = true;
            this.Joe_RadioButton.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Joe_RadioButton.Location = new System.Drawing.Point(14, 21);
            this.Joe_RadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Joe_RadioButton.Name = "Joe_RadioButton";
            this.Joe_RadioButton.Size = new System.Drawing.Size(43, 16);
            this.Joe_RadioButton.TabIndex = 8;
            this.Joe_RadioButton.TabStop = true;
            this.Joe_RadioButton.Text = "Joe";
            this.Joe_RadioButton.UseVisualStyleBackColor = true;
            this.Joe_RadioButton.CheckedChanged += new System.EventHandler(this.Joe_RadioButton_CheckedChanged);
            // 
            // Bob_RadioButton
            // 
            this.Bob_RadioButton.AutoSize = true;
            this.Bob_RadioButton.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Bob_RadioButton.Location = new System.Drawing.Point(14, 52);
            this.Bob_RadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bob_RadioButton.Name = "Bob_RadioButton";
            this.Bob_RadioButton.Size = new System.Drawing.Size(45, 16);
            this.Bob_RadioButton.TabIndex = 9;
            this.Bob_RadioButton.Text = "Bob";
            this.Bob_RadioButton.UseVisualStyleBackColor = true;
            this.Bob_RadioButton.CheckedChanged += new System.EventHandler(this.Bob_RadioButton_CheckedChanged);
            // 
            // Dog_Number_ComboBox
            // 
            this.Dog_Number_ComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.Dog_Number_ComboBox.FormattingEnabled = true;
            this.Dog_Number_ComboBox.Location = new System.Drawing.Point(355, 140);
            this.Dog_Number_ComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dog_Number_ComboBox.Name = "Dog_Number_ComboBox";
            this.Dog_Number_ComboBox.Size = new System.Drawing.Size(42, 20);
            this.Dog_Number_ComboBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bucks on Dog Number";
            // 
            // Bucks_ComboBox
            // 
            this.Bucks_ComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.Bucks_ComboBox.FormattingEnabled = true;
            this.Bucks_ComboBox.Location = new System.Drawing.Point(107, 140);
            this.Bucks_ComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bucks_ComboBox.Name = "Bucks_ComboBox";
            this.Bucks_ComboBox.Size = new System.Drawing.Size(106, 20);
            this.Bucks_ComboBox.TabIndex = 4;
            // 
            // GuyName
            // 
            this.GuyName.AutoSize = true;
            this.GuyName.Location = new System.Drawing.Point(4, 143);
            this.GuyName.Name = "GuyName";
            this.GuyName.Size = new System.Drawing.Size(25, 12);
            this.GuyName.TabIndex = 3;
            this.GuyName.Text = "Joe";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AI_RadioButton);
            this.groupBox2.Controls.Add(this.Joe_RadioButton);
            this.groupBox2.Controls.Add(this.Bob_RadioButton);
            this.groupBox2.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(7, 22);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(142, 114);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Minimum Bet";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.Dog_Number_ComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Bucks_ComboBox);
            this.groupBox1.Controls.Add(this.GuyName);
            this.groupBox1.Controls.Add(this.Race_Button);
            this.groupBox1.Controls.Add(this.Bets_Button);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 202);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(493, 168);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Betting Parlor";
            // 
            // Race_Button
            // 
            this.Race_Button.Location = new System.Drawing.Point(402, 124);
            this.Race_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Race_Button.Name = "Race_Button";
            this.Race_Button.Size = new System.Drawing.Size(85, 38);
            this.Race_Button.TabIndex = 2;
            this.Race_Button.Text = "Race!";
            this.Race_Button.UseVisualStyleBackColor = true;
            this.Race_Button.Click += new System.EventHandler(this.Race_Button_Click);
            // 
            // Bets_Button
            // 
            this.Bets_Button.Location = new System.Drawing.Point(36, 140);
            this.Bets_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bets_Button.Name = "Bets_Button";
            this.Bets_Button.Size = new System.Drawing.Size(66, 18);
            this.Bets_Button.TabIndex = 1;
            this.Bets_Button.Text = "Bets";
            this.Bets_Button.UseVisualStyleBackColor = true;
            this.Bets_Button.Click += new System.EventHandler(this.Bets_Button_Click);
            // 
            // Dog3_Pic
            // 
            this.Dog3_Pic.Location = new System.Drawing.Point(64, 159);
            this.Dog3_Pic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dog3_Pic.Name = "Dog3_Pic";
            this.Dog3_Pic.Size = new System.Drawing.Size(33, 28);
            this.Dog3_Pic.TabIndex = 14;
            this.Dog3_Pic.TabStop = false;
            // 
            // Dog2_Pic
            // 
            this.Dog2_Pic.Location = new System.Drawing.Point(64, 111);
            this.Dog2_Pic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dog2_Pic.Name = "Dog2_Pic";
            this.Dog2_Pic.Size = new System.Drawing.Size(33, 28);
            this.Dog2_Pic.TabIndex = 13;
            this.Dog2_Pic.TabStop = false;
            // 
            // Dog1_Pic
            // 
            this.Dog1_Pic.Location = new System.Drawing.Point(64, 63);
            this.Dog1_Pic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dog1_Pic.Name = "Dog1_Pic";
            this.Dog1_Pic.Size = new System.Drawing.Size(33, 28);
            this.Dog1_Pic.TabIndex = 12;
            this.Dog1_Pic.TabStop = false;
            // 
            // Dog0_Pic
            // 
            this.Dog0_Pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Dog0_Pic.Location = new System.Drawing.Point(64, 18);
            this.Dog0_Pic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dog0_Pic.Name = "Dog0_Pic";
            this.Dog0_Pic.Size = new System.Drawing.Size(33, 28);
            this.Dog0_Pic.TabIndex = 11;
            this.Dog0_Pic.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ADayAtTheRace.Properties.Resources.race;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(493, 187);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "경주시작";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(513, 377);
            this.Controls.Add(this.Dog3_Pic);
            this.Controls.Add(this.Dog2_Pic);
            this.Controls.Add(this.Dog1_Pic);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Dog0_Pic);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dog3_Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog2_Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog1_Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog0_Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bets_Button;
        private System.Windows.Forms.Button Race_Button;
        private System.Windows.Forms.ComboBox Bucks_ComboBox;
        private System.Windows.Forms.ComboBox Dog_Number_ComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label GuyName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Dog0_Pic;
        private System.Windows.Forms.PictureBox Dog1_Pic;
        private System.Windows.Forms.PictureBox Dog2_Pic;
        private System.Windows.Forms.PictureBox Dog3_Pic;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton AI_RadioButton;
        private System.Windows.Forms.RadioButton Bob_RadioButton;
        private System.Windows.Forms.RadioButton Joe_RadioButton;
        private System.Windows.Forms.TextBox AI_TextBox;
        private System.Windows.Forms.TextBox Bob_TextBox;
        private System.Windows.Forms.TextBox Joe_TextBox;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

