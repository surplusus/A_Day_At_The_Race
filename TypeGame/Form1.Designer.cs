namespace TypeGame
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Correct_Label = new System.Windows.Forms.ToolStripStatusLabel();
            this.Missed_Label = new System.Windows.Forms.ToolStripStatusLabel();
            this.Total_Label = new System.Windows.Forms.ToolStripStatusLabel();
            this.Accuracy_Label = new System.Windows.Forms.ToolStripStatusLabel();
            this.Difficulty_Label = new System.Windows.Forms.ToolStripStatusLabel();
            this.Difficulty_ProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("Times New Roman", 130F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 173;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(768, 225);
            this.listBox1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Verdana", 10F);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Correct_Label,
            this.Missed_Label,
            this.Total_Label,
            this.Accuracy_Label,
            this.Difficulty_Label,
            this.Difficulty_ProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 203);
            this.statusStrip1.Margin = new System.Windows.Forms.Padding(10);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(768, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Correct_Label
            // 
            this.Correct_Label.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Correct_Label.Name = "Correct_Label";
            this.Correct_Label.Size = new System.Drawing.Size(80, 17);
            this.Correct_Label.Text = "Correct: 0";
            // 
            // Missed_Label
            // 
            this.Missed_Label.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Missed_Label.Name = "Missed_Label";
            this.Missed_Label.Size = new System.Drawing.Size(75, 17);
            this.Missed_Label.Text = "Missed: 0";
            // 
            // Total_Label
            // 
            this.Total_Label.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Label.Name = "Total_Label";
            this.Total_Label.Size = new System.Drawing.Size(61, 17);
            this.Total_Label.Text = "Total: 0";
            // 
            // Accuracy_Label
            // 
            this.Accuracy_Label.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Accuracy_Label.Name = "Accuracy_Label";
            this.Accuracy_Label.Size = new System.Drawing.Size(105, 17);
            this.Accuracy_Label.Text = "Accuracy: 0%";
            // 
            // Difficulty_Label
            // 
            this.Difficulty_Label.Name = "Difficulty_Label";
            this.Difficulty_Label.Size = new System.Drawing.Size(330, 17);
            this.Difficulty_Label.Spring = true;
            this.Difficulty_Label.Text = "Difficulty";
            this.Difficulty_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Difficulty_ProgressBar
            // 
            this.Difficulty_ProgressBar.Name = "Difficulty_ProgressBar";
            this.Difficulty_ProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // timer1
            // 
            this.timer1.Interval = 800;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 225);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Correct_Label;
        private System.Windows.Forms.ToolStripStatusLabel Missed_Label;
        private System.Windows.Forms.ToolStripStatusLabel Total_Label;
        private System.Windows.Forms.ToolStripStatusLabel Accuracy_Label;
        private System.Windows.Forms.ToolStripStatusLabel Difficulty_Label;
        private System.Windows.Forms.ToolStripProgressBar Difficulty_ProgressBar;
        private System.Windows.Forms.Timer timer1;
    }
}

