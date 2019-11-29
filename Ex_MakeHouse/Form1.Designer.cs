namespace Ex_MakeHouse
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
            this.textBox_Desctiption = new System.Windows.Forms.TextBox();
            this.button_GoToHere = new System.Windows.Forms.Button();
            this.comboBox_Exits = new System.Windows.Forms.ComboBox();
            this.button_GoThDoor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Desctiption
            // 
            this.textBox_Desctiption.Location = new System.Drawing.Point(12, 12);
            this.textBox_Desctiption.Multiline = true;
            this.textBox_Desctiption.Name = "textBox_Desctiption";
            this.textBox_Desctiption.Size = new System.Drawing.Size(497, 246);
            this.textBox_Desctiption.TabIndex = 0;
            // 
            // button_GoToHere
            // 
            this.button_GoToHere.Location = new System.Drawing.Point(12, 282);
            this.button_GoToHere.Name = "button_GoToHere";
            this.button_GoToHere.Size = new System.Drawing.Size(239, 20);
            this.button_GoToHere.TabIndex = 1;
            this.button_GoToHere.Text = "Go To Here";
            this.button_GoToHere.UseVisualStyleBackColor = true;
            this.button_GoToHere.Click += new System.EventHandler(this.button_GoToHere_Click);
            // 
            // comboBox_Exits
            // 
            this.comboBox_Exits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Exits.FormattingEnabled = true;
            this.comboBox_Exits.Location = new System.Drawing.Point(258, 282);
            this.comboBox_Exits.Name = "comboBox_Exits";
            this.comboBox_Exits.Size = new System.Drawing.Size(251, 20);
            this.comboBox_Exits.TabIndex = 2;
            // 
            // button_GoThDoor
            // 
            this.button_GoThDoor.Location = new System.Drawing.Point(12, 320);
            this.button_GoThDoor.Name = "button_GoThDoor";
            this.button_GoThDoor.Size = new System.Drawing.Size(497, 33);
            this.button_GoThDoor.TabIndex = 3;
            this.button_GoThDoor.Text = "Go Through The Door";
            this.button_GoThDoor.UseVisualStyleBackColor = true;
            this.button_GoThDoor.Click += new System.EventHandler(this.button_GoThDoor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 365);
            this.Controls.Add(this.button_GoThDoor);
            this.Controls.Add(this.comboBox_Exits);
            this.Controls.Add(this.button_GoToHere);
            this.Controls.Add(this.textBox_Desctiption);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Desctiption;
        private System.Windows.Forms.Button button_GoToHere;
        private System.Windows.Forms.ComboBox comboBox_Exits;
        private System.Windows.Forms.Button button_GoThDoor;
    }
}

