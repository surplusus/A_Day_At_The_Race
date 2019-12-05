namespace The_Quest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AttackUp = new System.Windows.Forms.Button();
            this.AttackLeft = new System.Windows.Forms.Button();
            this.AttackDown = new System.Windows.Forms.Button();
            this.AttackRight = new System.Windows.Forms.Button();
            this.MoveUp = new System.Windows.Forms.Button();
            this.PlayerHitPointsCaption = new System.Windows.Forms.Label();
            this.BatHitPointsCaption = new System.Windows.Forms.Label();
            this.GhostHitPointsCaption = new System.Windows.Forms.Label();
            this.HitPointPanel = new System.Windows.Forms.TableLayoutPanel();
            this.GhoulHitPointsCaption = new System.Windows.Forms.Label();
            this.BatHitPoints = new System.Windows.Forms.Label();
            this.GhostHitPoints = new System.Windows.Forms.Label();
            this.GhoulHitPoints = new System.Windows.Forms.Label();
            this.PlayerHitPoints = new System.Windows.Forms.Label();
            this.MoveLeft = new System.Windows.Forms.Button();
            this.MoveDown = new System.Windows.Forms.Button();
            this.MoveRight = new System.Windows.Forms.Button();
            this.Move_panel = new System.Windows.Forms.Panel();
            this.MovePanel_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AttackPanel_label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SwordInvSprite = new System.Windows.Forms.PictureBox();
            this.RedPotionInvSprite = new System.Windows.Forms.PictureBox();
            this.BowInvSprite = new System.Windows.Forms.PictureBox();
            this.MaceInvSprite = new System.Windows.Forms.PictureBox();
            this.BluePotionInvSprite = new System.Windows.Forms.PictureBox();
            this.GhostSprite = new System.Windows.Forms.PictureBox();
            this.GhoulSprite = new System.Windows.Forms.PictureBox();
            this.BatSprite = new System.Windows.Forms.PictureBox();
            this.MaceSprite = new System.Windows.Forms.PictureBox();
            this.BluePotionSprite = new System.Windows.Forms.PictureBox();
            this.RedPotionSprite = new System.Windows.Forms.PictureBox();
            this.BowSprite = new System.Windows.Forms.PictureBox();
            this.SwordSprite = new System.Windows.Forms.PictureBox();
            this.PlayerSprite = new System.Windows.Forms.PictureBox();
            this.Map_pictureBox = new System.Windows.Forms.PictureBox();
            this.AttackRange_Up = new System.Windows.Forms.PictureBox();
            this.AttackRange_Left = new System.Windows.Forms.PictureBox();
            this.AttackRange_Down = new System.Windows.Forms.PictureBox();
            this.AttackRange_Right = new System.Windows.Forms.PictureBox();
            this.HitPointPanel.SuspendLayout();
            this.Move_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SwordInvSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedPotionInvSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BowInvSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaceInvSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BluePotionInvSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GhostSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GhoulSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BatSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaceSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BluePotionSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedPotionSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BowSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwordSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Map_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttackRange_Up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttackRange_Left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttackRange_Down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttackRange_Right)).BeginInit();
            this.SuspendLayout();
            // 
            // AttackUp
            // 
            this.AttackUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AttackUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AttackUp.Font = new System.Drawing.Font("D2Coding", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AttackUp.ForeColor = System.Drawing.Color.Gray;
            this.AttackUp.Location = new System.Drawing.Point(41, 50);
            this.AttackUp.Name = "AttackUp";
            this.AttackUp.Size = new System.Drawing.Size(83, 22);
            this.AttackUp.TabIndex = 0;
            this.AttackUp.TabStop = false;
            this.AttackUp.Text = "Up";
            this.AttackUp.UseVisualStyleBackColor = true;
            this.AttackUp.Click += new System.EventHandler(this.AttackUp_Click);
            // 
            // AttackLeft
            // 
            this.AttackLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AttackLeft.BackColor = System.Drawing.Color.Beige;
            this.AttackLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AttackLeft.Font = new System.Drawing.Font("D2Coding", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AttackLeft.ForeColor = System.Drawing.Color.Gray;
            this.AttackLeft.Location = new System.Drawing.Point(4, 87);
            this.AttackLeft.Name = "AttackLeft";
            this.AttackLeft.Size = new System.Drawing.Size(71, 22);
            this.AttackLeft.TabIndex = 0;
            this.AttackLeft.TabStop = false;
            this.AttackLeft.Text = "Left";
            this.AttackLeft.UseVisualStyleBackColor = false;
            this.AttackLeft.Click += new System.EventHandler(this.AttackLeft_Click);
            // 
            // AttackDown
            // 
            this.AttackDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AttackDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AttackDown.Font = new System.Drawing.Font("D2Coding", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AttackDown.ForeColor = System.Drawing.Color.Gray;
            this.AttackDown.Location = new System.Drawing.Point(41, 123);
            this.AttackDown.Name = "AttackDown";
            this.AttackDown.Size = new System.Drawing.Size(83, 22);
            this.AttackDown.TabIndex = 0;
            this.AttackDown.TabStop = false;
            this.AttackDown.Text = "Down";
            this.AttackDown.UseVisualStyleBackColor = true;
            this.AttackDown.Click += new System.EventHandler(this.AttackDown_Click);
            // 
            // AttackRight
            // 
            this.AttackRight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AttackRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AttackRight.Font = new System.Drawing.Font("D2Coding", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AttackRight.ForeColor = System.Drawing.Color.Gray;
            this.AttackRight.Location = new System.Drawing.Point(84, 87);
            this.AttackRight.Name = "AttackRight";
            this.AttackRight.Size = new System.Drawing.Size(71, 22);
            this.AttackRight.TabIndex = 0;
            this.AttackRight.TabStop = false;
            this.AttackRight.Text = "Right";
            this.AttackRight.UseVisualStyleBackColor = true;
            this.AttackRight.Click += new System.EventHandler(this.AttackRight_Click);
            // 
            // MoveUp
            // 
            this.MoveUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MoveUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MoveUp.Font = new System.Drawing.Font("D2Coding", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MoveUp.ForeColor = System.Drawing.Color.Gray;
            this.MoveUp.Location = new System.Drawing.Point(41, 49);
            this.MoveUp.Name = "MoveUp";
            this.MoveUp.Size = new System.Drawing.Size(83, 22);
            this.MoveUp.TabIndex = 0;
            this.MoveUp.TabStop = false;
            this.MoveUp.Text = "Up";
            this.MoveUp.UseVisualStyleBackColor = true;
            this.MoveUp.Click += new System.EventHandler(this.MoveUp_Click);
            // 
            // PlayerHitPointsCaption
            // 
            this.PlayerHitPointsCaption.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PlayerHitPointsCaption.AutoSize = true;
            this.PlayerHitPointsCaption.Font = new System.Drawing.Font("궁서", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PlayerHitPointsCaption.Location = new System.Drawing.Point(4, 3);
            this.PlayerHitPointsCaption.Name = "PlayerHitPointsCaption";
            this.PlayerHitPointsCaption.Size = new System.Drawing.Size(54, 15);
            this.PlayerHitPointsCaption.TabIndex = 0;
            this.PlayerHitPointsCaption.Text = "Player";
            // 
            // BatHitPointsCaption
            // 
            this.BatHitPointsCaption.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BatHitPointsCaption.AutoSize = true;
            this.BatHitPointsCaption.Font = new System.Drawing.Font("궁서", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BatHitPointsCaption.Location = new System.Drawing.Point(4, 24);
            this.BatHitPointsCaption.Name = "BatHitPointsCaption";
            this.BatHitPointsCaption.Size = new System.Drawing.Size(31, 15);
            this.BatHitPointsCaption.TabIndex = 1;
            this.BatHitPointsCaption.Text = "Bat";
            // 
            // GhostHitPointsCaption
            // 
            this.GhostHitPointsCaption.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GhostHitPointsCaption.AutoSize = true;
            this.GhostHitPointsCaption.Font = new System.Drawing.Font("궁서", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.GhostHitPointsCaption.Location = new System.Drawing.Point(4, 45);
            this.GhostHitPointsCaption.Name = "GhostHitPointsCaption";
            this.GhostHitPointsCaption.Size = new System.Drawing.Size(50, 15);
            this.GhostHitPointsCaption.TabIndex = 2;
            this.GhostHitPointsCaption.Text = "Ghost";
            // 
            // HitPointPanel
            // 
            this.HitPointPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.HitPointPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.HitPointPanel.ColumnCount = 2;
            this.HitPointPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.88889F));
            this.HitPointPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.11111F));
            this.HitPointPanel.Controls.Add(this.PlayerHitPointsCaption, 0, 0);
            this.HitPointPanel.Controls.Add(this.BatHitPointsCaption, 0, 1);
            this.HitPointPanel.Controls.Add(this.GhostHitPointsCaption, 0, 2);
            this.HitPointPanel.Controls.Add(this.GhoulHitPointsCaption, 0, 3);
            this.HitPointPanel.Controls.Add(this.BatHitPoints, 1, 1);
            this.HitPointPanel.Controls.Add(this.GhostHitPoints, 1, 2);
            this.HitPointPanel.Controls.Add(this.GhoulHitPoints, 1, 3);
            this.HitPointPanel.Controls.Add(this.PlayerHitPoints, 1, 0);
            this.HitPointPanel.Location = new System.Drawing.Point(710, 383);
            this.HitPointPanel.Name = "HitPointPanel";
            this.HitPointPanel.RowCount = 4;
            this.HitPointPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.HitPointPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.HitPointPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.HitPointPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.HitPointPanel.Size = new System.Drawing.Size(163, 88);
            this.HitPointPanel.TabIndex = 31;
            // 
            // GhoulHitPointsCaption
            // 
            this.GhoulHitPointsCaption.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GhoulHitPointsCaption.AutoSize = true;
            this.GhoulHitPointsCaption.Font = new System.Drawing.Font("궁서", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.GhoulHitPointsCaption.Location = new System.Drawing.Point(4, 68);
            this.GhoulHitPointsCaption.Name = "GhoulHitPointsCaption";
            this.GhoulHitPointsCaption.Size = new System.Drawing.Size(50, 15);
            this.GhoulHitPointsCaption.TabIndex = 3;
            this.GhoulHitPointsCaption.Text = "Ghoul";
            // 
            // BatHitPoints
            // 
            this.BatHitPoints.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BatHitPoints.AutoSize = true;
            this.BatHitPoints.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BatHitPoints.Location = new System.Drawing.Point(67, 22);
            this.BatHitPoints.Name = "BatHitPoints";
            this.BatHitPoints.Size = new System.Drawing.Size(90, 20);
            this.BatHitPoints.TabIndex = 5;
            this.BatHitPoints.Text = "BatHitPoints";
            // 
            // GhostHitPoints
            // 
            this.GhostHitPoints.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GhostHitPoints.AutoSize = true;
            this.GhostHitPoints.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GhostHitPoints.Location = new System.Drawing.Point(67, 43);
            this.GhostHitPoints.Name = "GhostHitPoints";
            this.GhostHitPoints.Size = new System.Drawing.Size(92, 20);
            this.GhostHitPoints.TabIndex = 6;
            this.GhostHitPoints.Text = "GhostHitPoints";
            // 
            // GhoulHitPoints
            // 
            this.GhoulHitPoints.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GhoulHitPoints.AutoSize = true;
            this.GhoulHitPoints.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GhoulHitPoints.Location = new System.Drawing.Point(67, 64);
            this.GhoulHitPoints.Name = "GhoulHitPoints";
            this.GhoulHitPoints.Size = new System.Drawing.Size(90, 23);
            this.GhoulHitPoints.TabIndex = 7;
            this.GhoulHitPoints.Text = "GhoulHitPoints";
            // 
            // PlayerHitPoints
            // 
            this.PlayerHitPoints.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PlayerHitPoints.AutoSize = true;
            this.PlayerHitPoints.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerHitPoints.Location = new System.Drawing.Point(67, 1);
            this.PlayerHitPoints.Name = "PlayerHitPoints";
            this.PlayerHitPoints.Size = new System.Drawing.Size(92, 20);
            this.PlayerHitPoints.TabIndex = 4;
            this.PlayerHitPoints.Text = "PlayerHitPoints";
            // 
            // MoveLeft
            // 
            this.MoveLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MoveLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MoveLeft.Font = new System.Drawing.Font("D2Coding", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MoveLeft.ForeColor = System.Drawing.Color.Gray;
            this.MoveLeft.Location = new System.Drawing.Point(4, 86);
            this.MoveLeft.Name = "MoveLeft";
            this.MoveLeft.Size = new System.Drawing.Size(71, 22);
            this.MoveLeft.TabIndex = 0;
            this.MoveLeft.TabStop = false;
            this.MoveLeft.Text = "Left";
            this.MoveLeft.UseVisualStyleBackColor = true;
            this.MoveLeft.Click += new System.EventHandler(this.MoveLeft_Click);
            // 
            // MoveDown
            // 
            this.MoveDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MoveDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MoveDown.Font = new System.Drawing.Font("D2Coding", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MoveDown.ForeColor = System.Drawing.Color.Gray;
            this.MoveDown.Location = new System.Drawing.Point(41, 122);
            this.MoveDown.Name = "MoveDown";
            this.MoveDown.Size = new System.Drawing.Size(83, 22);
            this.MoveDown.TabIndex = 0;
            this.MoveDown.TabStop = false;
            this.MoveDown.Text = "Down";
            this.MoveDown.UseVisualStyleBackColor = true;
            this.MoveDown.Click += new System.EventHandler(this.MoveDown_Click);
            // 
            // MoveRight
            // 
            this.MoveRight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MoveRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MoveRight.Font = new System.Drawing.Font("D2Coding", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MoveRight.ForeColor = System.Drawing.Color.Gray;
            this.MoveRight.Location = new System.Drawing.Point(84, 86);
            this.MoveRight.Name = "MoveRight";
            this.MoveRight.Size = new System.Drawing.Size(71, 22);
            this.MoveRight.TabIndex = 0;
            this.MoveRight.TabStop = false;
            this.MoveRight.Text = "Right";
            this.MoveRight.UseVisualStyleBackColor = true;
            this.MoveRight.Click += new System.EventHandler(this.MoveRight_Click);
            // 
            // Move_panel
            // 
            this.Move_panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Move_panel.Controls.Add(this.MoveRight);
            this.Move_panel.Controls.Add(this.MoveLeft);
            this.Move_panel.Controls.Add(this.MoveDown);
            this.Move_panel.Controls.Add(this.MovePanel_label);
            this.Move_panel.Controls.Add(this.MoveUp);
            this.Move_panel.Location = new System.Drawing.Point(710, 12);
            this.Move_panel.Name = "Move_panel";
            this.Move_panel.Padding = new System.Windows.Forms.Padding(2);
            this.Move_panel.Size = new System.Drawing.Size(162, 159);
            this.Move_panel.TabIndex = 35;
            // 
            // MovePanel_label
            // 
            this.MovePanel_label.AutoSize = true;
            this.MovePanel_label.Font = new System.Drawing.Font("굴림", 20F);
            this.MovePanel_label.Location = new System.Drawing.Point(36, 13);
            this.MovePanel_label.Name = "MovePanel_label";
            this.MovePanel_label.Size = new System.Drawing.Size(88, 27);
            this.MovePanel_label.TabIndex = 34;
            this.MovePanel_label.Text = "MOVE";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.AttackPanel_label);
            this.panel1.Controls.Add(this.AttackDown);
            this.panel1.Controls.Add(this.AttackUp);
            this.panel1.Controls.Add(this.AttackRight);
            this.panel1.Controls.Add(this.AttackLeft);
            this.panel1.Location = new System.Drawing.Point(710, 188);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 165);
            this.panel1.TabIndex = 36;
            // 
            // AttackPanel_label
            // 
            this.AttackPanel_label.AutoSize = true;
            this.AttackPanel_label.Font = new System.Drawing.Font("굴림", 20F);
            this.AttackPanel_label.Location = new System.Drawing.Point(26, 13);
            this.AttackPanel_label.Name = "AttackPanel_label";
            this.AttackPanel_label.Size = new System.Drawing.Size(114, 27);
            this.AttackPanel_label.TabIndex = 35;
            this.AttackPanel_label.Text = "ATTACK";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.SwordInvSprite);
            this.panel2.Controls.Add(this.RedPotionInvSprite);
            this.panel2.Controls.Add(this.BowInvSprite);
            this.panel2.Controls.Add(this.MaceInvSprite);
            this.panel2.Controls.Add(this.BluePotionInvSprite);
            this.panel2.Location = new System.Drawing.Point(309, 443);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(394, 55);
            this.panel2.TabIndex = 37;
            // 
            // SwordInvSprite
            // 
            this.SwordInvSprite.BackColor = System.Drawing.Color.Bisque;
            this.SwordInvSprite.ErrorImage = global::The_Quest.Properties.Resources.sword;
            this.SwordInvSprite.Location = new System.Drawing.Point(3, 3);
            this.SwordInvSprite.Name = "SwordInvSprite";
            this.SwordInvSprite.Size = new System.Drawing.Size(58, 46);
            this.SwordInvSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SwordInvSprite.TabIndex = 26;
            this.SwordInvSprite.TabStop = false;
            this.SwordInvSprite.Visible = false;
            this.SwordInvSprite.Click += new System.EventHandler(this.SwordInvSprite_Click);
            // 
            // RedPotionInvSprite
            // 
            this.RedPotionInvSprite.BackColor = System.Drawing.Color.Bisque;
            this.RedPotionInvSprite.Location = new System.Drawing.Point(263, 3);
            this.RedPotionInvSprite.Name = "RedPotionInvSprite";
            this.RedPotionInvSprite.Size = new System.Drawing.Size(58, 46);
            this.RedPotionInvSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RedPotionInvSprite.TabIndex = 27;
            this.RedPotionInvSprite.TabStop = false;
            this.RedPotionInvSprite.Visible = false;
            this.RedPotionInvSprite.Click += new System.EventHandler(this.RedPotionInvSprite_Click);
            // 
            // BowInvSprite
            // 
            this.BowInvSprite.BackColor = System.Drawing.Color.Bisque;
            this.BowInvSprite.Location = new System.Drawing.Point(79, 3);
            this.BowInvSprite.Name = "BowInvSprite";
            this.BowInvSprite.Size = new System.Drawing.Size(58, 46);
            this.BowInvSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BowInvSprite.TabIndex = 29;
            this.BowInvSprite.TabStop = false;
            this.BowInvSprite.Visible = false;
            this.BowInvSprite.Click += new System.EventHandler(this.BowInvSprite_Click);
            // 
            // MaceInvSprite
            // 
            this.MaceInvSprite.BackColor = System.Drawing.Color.Bisque;
            this.MaceInvSprite.Location = new System.Drawing.Point(153, 3);
            this.MaceInvSprite.Name = "MaceInvSprite";
            this.MaceInvSprite.Size = new System.Drawing.Size(58, 46);
            this.MaceInvSprite.TabIndex = 30;
            this.MaceInvSprite.TabStop = false;
            this.MaceInvSprite.Visible = false;
            this.MaceInvSprite.Click += new System.EventHandler(this.MaceInvSprite_Click);
            // 
            // BluePotionInvSprite
            // 
            this.BluePotionInvSprite.BackColor = System.Drawing.Color.Bisque;
            this.BluePotionInvSprite.Location = new System.Drawing.Point(333, 3);
            this.BluePotionInvSprite.Name = "BluePotionInvSprite";
            this.BluePotionInvSprite.Size = new System.Drawing.Size(58, 46);
            this.BluePotionInvSprite.TabIndex = 28;
            this.BluePotionInvSprite.TabStop = false;
            this.BluePotionInvSprite.Visible = false;
            this.BluePotionInvSprite.Click += new System.EventHandler(this.BluePotionInvSprite_Click);
            // 
            // GhostSprite
            // 
            this.GhostSprite.BackColor = System.Drawing.Color.Transparent;
            this.GhostSprite.Image = global::The_Quest.Properties.Resources.ghost;
            this.GhostSprite.Location = new System.Drawing.Point(356, 188);
            this.GhostSprite.Name = "GhostSprite";
            this.GhostSprite.Size = new System.Drawing.Size(35, 28);
            this.GhostSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GhostSprite.TabIndex = 21;
            this.GhostSprite.TabStop = false;
            this.GhostSprite.Visible = false;
            // 
            // GhoulSprite
            // 
            this.GhoulSprite.BackColor = System.Drawing.Color.Transparent;
            this.GhoulSprite.Image = global::The_Quest.Properties.Resources.ghoul;
            this.GhoulSprite.Location = new System.Drawing.Point(398, 188);
            this.GhoulSprite.Name = "GhoulSprite";
            this.GhoulSprite.Size = new System.Drawing.Size(35, 28);
            this.GhoulSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GhoulSprite.TabIndex = 20;
            this.GhoulSprite.TabStop = false;
            this.GhoulSprite.Visible = false;
            // 
            // BatSprite
            // 
            this.BatSprite.BackColor = System.Drawing.Color.Transparent;
            this.BatSprite.Image = global::The_Quest.Properties.Resources.bat;
            this.BatSprite.Location = new System.Drawing.Point(316, 188);
            this.BatSprite.Name = "BatSprite";
            this.BatSprite.Size = new System.Drawing.Size(35, 28);
            this.BatSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BatSprite.TabIndex = 19;
            this.BatSprite.TabStop = false;
            this.BatSprite.Visible = false;
            // 
            // MaceSprite
            // 
            this.MaceSprite.BackColor = System.Drawing.Color.Transparent;
            this.MaceSprite.Image = global::The_Quest.Properties.Resources.mace;
            this.MaceSprite.Location = new System.Drawing.Point(608, 188);
            this.MaceSprite.Name = "MaceSprite";
            this.MaceSprite.Size = new System.Drawing.Size(35, 28);
            this.MaceSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MaceSprite.TabIndex = 25;
            this.MaceSprite.TabStop = false;
            this.MaceSprite.Visible = false;
            // 
            // BluePotionSprite
            // 
            this.BluePotionSprite.BackColor = System.Drawing.Color.Transparent;
            this.BluePotionSprite.Image = global::The_Quest.Properties.Resources.potion_blue;
            this.BluePotionSprite.Location = new System.Drawing.Point(482, 188);
            this.BluePotionSprite.Name = "BluePotionSprite";
            this.BluePotionSprite.Size = new System.Drawing.Size(35, 28);
            this.BluePotionSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BluePotionSprite.TabIndex = 24;
            this.BluePotionSprite.TabStop = false;
            this.BluePotionSprite.Visible = false;
            // 
            // RedPotionSprite
            // 
            this.RedPotionSprite.BackColor = System.Drawing.Color.Transparent;
            this.RedPotionSprite.Image = global::The_Quest.Properties.Resources.potion_red;
            this.RedPotionSprite.Location = new System.Drawing.Point(441, 188);
            this.RedPotionSprite.Name = "RedPotionSprite";
            this.RedPotionSprite.Size = new System.Drawing.Size(35, 28);
            this.RedPotionSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RedPotionSprite.TabIndex = 23;
            this.RedPotionSprite.TabStop = false;
            this.RedPotionSprite.Visible = false;
            // 
            // BowSprite
            // 
            this.BowSprite.BackColor = System.Drawing.Color.Transparent;
            this.BowSprite.Image = global::The_Quest.Properties.Resources.bow;
            this.BowSprite.Location = new System.Drawing.Point(567, 188);
            this.BowSprite.Name = "BowSprite";
            this.BowSprite.Size = new System.Drawing.Size(35, 28);
            this.BowSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BowSprite.TabIndex = 22;
            this.BowSprite.TabStop = false;
            this.BowSprite.Visible = false;
            // 
            // SwordSprite
            // 
            this.SwordSprite.BackColor = System.Drawing.Color.Transparent;
            this.SwordSprite.Image = global::The_Quest.Properties.Resources.sword;
            this.SwordSprite.Location = new System.Drawing.Point(526, 188);
            this.SwordSprite.Name = "SwordSprite";
            this.SwordSprite.Size = new System.Drawing.Size(35, 28);
            this.SwordSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SwordSprite.TabIndex = 18;
            this.SwordSprite.TabStop = false;
            this.SwordSprite.Visible = false;
            // 
            // PlayerSprite
            // 
            this.PlayerSprite.BackColor = System.Drawing.Color.Transparent;
            this.PlayerSprite.Image = global::The_Quest.Properties.Resources.player;
            this.PlayerSprite.Location = new System.Drawing.Point(272, 188);
            this.PlayerSprite.Name = "PlayerSprite";
            this.PlayerSprite.Size = new System.Drawing.Size(35, 28);
            this.PlayerSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerSprite.TabIndex = 17;
            this.PlayerSprite.TabStop = false;
            // 
            // Map_pictureBox
            // 
            this.Map_pictureBox.Image = global::The_Quest.Properties.Resources.map;
            this.Map_pictureBox.Location = new System.Drawing.Point(12, 12);
            this.Map_pictureBox.Name = "Map_pictureBox";
            this.Map_pictureBox.Size = new System.Drawing.Size(691, 425);
            this.Map_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Map_pictureBox.TabIndex = 34;
            this.Map_pictureBox.TabStop = false;
            // 
            // AttackRange_Up
            // 
            this.AttackRange_Up.BackColor = System.Drawing.Color.Transparent;
            this.AttackRange_Up.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AttackRange_Up.Location = new System.Drawing.Point(59, 446);
            this.AttackRange_Up.Name = "AttackRange_Up";
            this.AttackRange_Up.Size = new System.Drawing.Size(28, 28);
            this.AttackRange_Up.TabIndex = 40;
            this.AttackRange_Up.TabStop = false;
            // 
            // AttackRange_Left
            // 
            this.AttackRange_Left.BackColor = System.Drawing.Color.Transparent;
            this.AttackRange_Left.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AttackRange_Left.Location = new System.Drawing.Point(161, 446);
            this.AttackRange_Left.Name = "AttackRange_Left";
            this.AttackRange_Left.Size = new System.Drawing.Size(28, 28);
            this.AttackRange_Left.TabIndex = 41;
            this.AttackRange_Left.TabStop = false;
            // 
            // AttackRange_Down
            // 
            this.AttackRange_Down.BackColor = System.Drawing.Color.Transparent;
            this.AttackRange_Down.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AttackRange_Down.Location = new System.Drawing.Point(127, 447);
            this.AttackRange_Down.Name = "AttackRange_Down";
            this.AttackRange_Down.Size = new System.Drawing.Size(28, 28);
            this.AttackRange_Down.TabIndex = 42;
            this.AttackRange_Down.TabStop = false;
            // 
            // AttackRange_Right
            // 
            this.AttackRange_Right.BackColor = System.Drawing.Color.Transparent;
            this.AttackRange_Right.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AttackRange_Right.Location = new System.Drawing.Point(93, 447);
            this.AttackRange_Right.Name = "AttackRange_Right";
            this.AttackRange_Right.Size = new System.Drawing.Size(28, 28);
            this.AttackRange_Right.TabIndex = 43;
            this.AttackRange_Right.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 508);
            this.Controls.Add(this.AttackRange_Right);
            this.Controls.Add(this.AttackRange_Down);
            this.Controls.Add(this.AttackRange_Left);
            this.Controls.Add(this.AttackRange_Up);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.HitPointPanel);
            this.Controls.Add(this.GhostSprite);
            this.Controls.Add(this.GhoulSprite);
            this.Controls.Add(this.BatSprite);
            this.Controls.Add(this.MaceSprite);
            this.Controls.Add(this.BluePotionSprite);
            this.Controls.Add(this.RedPotionSprite);
            this.Controls.Add(this.BowSprite);
            this.Controls.Add(this.SwordSprite);
            this.Controls.Add(this.PlayerSprite);
            this.Controls.Add(this.Map_pictureBox);
            this.Controls.Add(this.Move_panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.HitPointPanel.ResumeLayout(false);
            this.HitPointPanel.PerformLayout();
            this.Move_panel.ResumeLayout(false);
            this.Move_panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SwordInvSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedPotionInvSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BowInvSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaceInvSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BluePotionInvSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GhostSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GhoulSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BatSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaceSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BluePotionSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedPotionSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BowSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwordSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Map_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttackRange_Up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttackRange_Left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttackRange_Down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttackRange_Right)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AttackUp;
        private System.Windows.Forms.Button AttackLeft;
        private System.Windows.Forms.Button AttackRight;
        private System.Windows.Forms.Button AttackDown;
        private System.Windows.Forms.Button MoveUp;
        private System.Windows.Forms.Label PlayerHitPointsCaption;
        private System.Windows.Forms.Label BatHitPointsCaption;
        private System.Windows.Forms.Label GhostHitPointsCaption;
        private System.Windows.Forms.TableLayoutPanel HitPointPanel;
        private System.Windows.Forms.Label GhoulHitPointsCaption;
        private System.Windows.Forms.Label PlayerHitPoints;
        private System.Windows.Forms.Label BatHitPoints;
        private System.Windows.Forms.Label GhostHitPoints;
        private System.Windows.Forms.Label GhoulHitPoints;
        private System.Windows.Forms.PictureBox MaceInvSprite;
        private System.Windows.Forms.PictureBox BowInvSprite;
        private System.Windows.Forms.PictureBox BluePotionInvSprite;
        private System.Windows.Forms.PictureBox RedPotionInvSprite;
        private System.Windows.Forms.PictureBox SwordInvSprite;
        private System.Windows.Forms.PictureBox GhostSprite;
        private System.Windows.Forms.PictureBox GhoulSprite;
        private System.Windows.Forms.PictureBox BatSprite;
        private System.Windows.Forms.PictureBox MaceSprite;
        private System.Windows.Forms.PictureBox BluePotionSprite;
        private System.Windows.Forms.PictureBox RedPotionSprite;
        private System.Windows.Forms.PictureBox BowSprite;
        private System.Windows.Forms.PictureBox SwordSprite;
        private System.Windows.Forms.PictureBox PlayerSprite;
        private System.Windows.Forms.PictureBox Map_pictureBox;
        private System.Windows.Forms.Button MoveLeft;
        private System.Windows.Forms.Button MoveDown;
        private System.Windows.Forms.Button MoveRight;
        private System.Windows.Forms.Panel Move_panel;
        private System.Windows.Forms.Label MovePanel_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AttackPanel_label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox AttackRange_Up;
        private System.Windows.Forms.PictureBox AttackRange_Left;
        private System.Windows.Forms.PictureBox AttackRange_Down;
        private System.Windows.Forms.PictureBox AttackRange_Right;
    }
}

