using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ADayAtTheRace
{
    public partial class Form1 : Form
    {
        private Guy[] guys = new Guy[3];
        private Horse[] horses = new Horse[4];
        public Form1()
        {
            InitializeComponent();

            guys[0] = new Guy("Joe", GuyName, Joe_TextBox, Joe_RadioButton);
            guys[1] = new Guy("Bob", GuyName, Bob_TextBox, Bob_RadioButton);
            guys[2] = new Guy("AI", GuyName, AI_TextBox,  AI_RadioButton);

            horses[0] = new Horse(Dog0_Pic, 0);
            horses[1] = new Horse(Dog1_Pic, 1);
            horses[2] = new Horse(Dog2_Pic, 2);
            horses[3] = new Horse(Dog3_Pic, 3);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // 폼 전체에서 키 입력 활성화
            KeyPreview = true;

            {   // comboBox
                int[] data = Enumerable.Range(0, 25).ToArray<int>();
                foreach (int n in data)
                    Bucks_ComboBox.Items.Add(n.ToString());
                Bucks_ComboBox.SelectedIndex = 0;

                foreach (int n in Enumerable.Range(1, 4).ToArray<int>())
                    Dog_Number_ComboBox.Items.Add(n.ToString());
                Dog_Number_ComboBox.SelectedIndex = 0;
            }

            foreach (Guy guy in guys)
            {
                guy.ClearBet();
                guy.UpdateLabels();
            }
            GuyName.Text = "Joe";
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (MessageBox.Show("게임을 종료하시겠습니까?", "종료"
                    , MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Dispose();
                    Application.Exit();
                }
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            foreach (Horse horse in horses)
            {
                if (!horse.Run())
                {
                    Timer.Stop();
                    foreach (Horse horse2 in horses)
                    {
                        horse2.Toggle_PlaySprite();
                    }
                    if (MessageBox.Show($"승자는! ${horse.StartingPosition + 1}번 말!") == DialogResult.OK)
                    {
                        foreach (Horse horse1 in horses)
                        {
                            horse1.TakeStartingPosition();
                        }
                        foreach (Guy guy in guys)
                        {
                            // won the bets by winner(horse number)
                            guy.Collect(horse.StartingPosition);
                            guy.ClearBet();
                            Joe_RadioButton.Checked = true;
                            GuyName.Text = "Joe";
                            if (guy.Cash <= 0)
                                if (MessageBox.Show($"<{guy.Name}>이 털려브렀으~") == DialogResult.OK)
                                    Application.Exit();
                                    
                        }
                        return;
                    }
                }
            }

        }
        private void Bets_Button_Click(object sender, EventArgs e)
        {
            switch (GuyName.Text)
            {
                case "Joe":
                    guys[0].UpdateLabels();
                    if (!guys[0].PlaceBet(Bucks_ComboBox.SelectedIndex, Dog_Number_ComboBox.SelectedIndex))
                    {
                        MessageBox.Show("Joe! 돈 없으면 집에 가슈~");
                    }
                    break;
                case "Bob":
                    guys[1].UpdateLabels();
                    if (!guys[1].PlaceBet(Bucks_ComboBox.SelectedIndex, Dog_Number_ComboBox.SelectedIndex))
                    {
                        MessageBox.Show("Bob! 돈 없으면 집에 가슈~");
                    }
                    break;
                case "AI":
                    guys[2].UpdateLabels();
                    if (!guys[2].PlaceBet(Bucks_ComboBox.SelectedIndex, Dog_Number_ComboBox.SelectedIndex))
                    {
                        MessageBox.Show("콤퓨타! 돈 없으면 집에 가슈~");
                    }
                    break;
                default:
                    break;
            }
        }
        private void Race_Button_Click(object sender, EventArgs e)
        {
            bool allBet = true;
            foreach (Guy guy in guys)
            {
                if (guy.MyBet == null)
                    allBet = false;
            }
            if (allBet)
            {
                Timer.Start();
                foreach (Horse horse in horses)
                {
                    horse.Toggle_PlaySprite();
                }
            }
            else
                MessageBox.Show("자~ 자! 다들 돈 거시고~!");
        }
        private void Joe_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            GuyName.Text = "Joe";
        }

        private void Bob_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            GuyName.Text = "Bob";
        }

        private void AI_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            GuyName.Text = "AI";
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;
            else if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Minimized;
            this.Activate();
        }
        public static DialogResult DialogBox(string title, string promptText, ref string value, string button1 = "OK", string button2 = "Cancel", string button3 = null)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button button_1 = new Button();
            Button button_2 = new Button();
            Button button_3 = new Button();

            int buttonStartPos = 228; //Standard two button position


            if (button3 != null)
                buttonStartPos = 228 - 81;
            else
            {
                button_3.Visible = false;
                button_3.Enabled = false;
            }


            form.Text = title;

            // Label
            label.Text = promptText;
            label.SetBounds(9, 20, 372, 13);
            label.Font = new Font("Microsoft Tai Le", 10, FontStyle.Regular);

            // TextBox
            if (value == null)
            {
            }
            else
            {
                textBox.Text = value;
                textBox.SetBounds(12, 36, 372, 20);
                textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            }

            button_1.Text = button1;
            button_2.Text = button2;
            button_3.Text = button3 ?? string.Empty;
            button_1.DialogResult = DialogResult.OK;
            button_2.DialogResult = DialogResult.Cancel;
            button_3.DialogResult = DialogResult.Yes;


            button_1.SetBounds(buttonStartPos, 72, 75, 23);
            button_2.SetBounds(buttonStartPos + 81, 72, 75, 23);
            button_3.SetBounds(buttonStartPos + (2 * 81), 72, 75, 23);

            label.AutoSize = true;
            button_1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, button_1, button_2 });
            if (button3 != null)
                form.Controls.Add(button_3);
            if (value != null)
                form.Controls.Add(textBox);

            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = button_1;
            form.CancelButton = button_2;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string str = null;
            DialogBox("sdf", "123",ref str, "네네");
        }
    }
}
