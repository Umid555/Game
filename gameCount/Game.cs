using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gameCount
{
    public partial class Game : Form
    {
        int winscore = 0;
        int seedcount = 0;
        int main_score = 0;
        Button btn = new Button();
        public Game()
        {
            InitializeComponent();
        }

        public void play()
        {
            int aim = seedcount;
            if (winscore>=15)
            {
                while (aim < main_score)
                {
                    aim += 4;
                }
                if (main_score + 1 == aim)
                {
                    main_score++;
                }
                else if (main_score + 2 == aim)
                {
                    main_score += 2;
                }
                else if (main_score+3==aim)
                {
                    main_score += 3;
                }
                else
                {
                    Random rd = new Random();
                    int a = rd.Next(1, 4);
                    main_score += a;
                }
            }
            else
            {
                while (aim < main_score)
                {
                    aim += 3;
                }
                if (main_score + 1 == aim)
                {
                    main_score++;
                }
                else if (main_score + 2 == aim)
                {
                    main_score += 2;
                }
                else
                {
                    Random rd = new Random();
                    int a = rd.Next(1, 3);
                    main_score += a;
                }
            }
            
            if (main_score>=winscore)
            {
                lbl_mainscore.Text = winscore.ToString();
                lbl_computerscore.Text = winscore.ToString();
                MessageBox.Show("Computer won!");
                btn_increaseone.Enabled = false;
                btn_increasetwo.Enabled = false;
                btn.Enabled = false;
            }
            else
            {
                lbl_mainscore.Text = main_score.ToString();
                lbl_computerscore.Text = main_score.ToString();
                btn_increaseone.Text = (main_score + 1).ToString();
                btn_increasetwo.Text = (main_score + 2).ToString();
                if (winscore>=15)
                {
                    btn.Text = (main_score + 3).ToString();
                }
            }
            
        }
        public void reset()
        {
            if (winscore>=15)
            {
                btn.Enabled = false;
                btn.Text = "+3";
            }
            winscore = 0;
            seedcount = 0;
            main_score = 0;
            tb_winpoint.Clear();
            btn_firstplayer.Enabled = false;
            btn_firstcomputer.Enabled = false;
            btn_increaseone.Enabled = false;
            btn_increasetwo.Enabled = false;
            btn_increaseone.Text = "+1";
            btn_increasetwo.Text = "+2";
            lbl_mainscore.Text = "0";
            lbl_playerscore.Text = "0";
            lbl_computerscore.Text = "0";
            
        }
        public void add_third_button()
        {
            btn.Size = new Size(164, 49);
            btn.Name = "btn_increase_three";
            btn.Location = new Point(550, 363);
            btn.Text = "+3";
            btn.Click += new EventHandler(btn_increasethree_Click);
            btn.BackColor = Color.White;
            btn_increaseone.Location = new Point(150, 363);
            btn_increasetwo.Location = new Point(350, 363);
            Controls.Add(btn);
            btn.Enabled = false;
        }



        private void btn_start_Click(object sender, EventArgs e)
        {
            if (tb_winpoint.Text=="")
            {
                MessageBox.Show("Enter valid number!");
            }
            else
            {
                winscore = Convert.ToInt32(tb_winpoint.Text);
                if (winscore >= 15)
                {
                    add_third_button();
                    seedcount = winscore % 4;
                }
                else
                {
                    seedcount = winscore % 3;
                }
                btn_firstcomputer.Enabled = true;
                btn_firstplayer.Enabled = true;
            }


            
        }
        private void btn_increasethree_Click(object sender, EventArgs e)
        {
            main_score += 3;
            if (main_score >= winscore)
            {
                lbl_mainscore.Text = winscore.ToString();
                lbl_playerscore.Text = winscore.ToString();
                MessageBox.Show("You won!");
                btn_increaseone.Enabled = false;
                btn_increasetwo.Enabled = false;

            }
            else
            {
                lbl_playerscore.Text = main_score.ToString();
                lbl_mainscore.Text = main_score.ToString();
                play();
            }
        }

        private void btn_firstplayer_Click(object sender, EventArgs e)
        {
            btn_increaseone.Enabled = true;
            btn_increasetwo.Enabled = true;
            btn_increaseone.Text = "1";
            btn_increasetwo.Text = "2";
            if (winscore>=15)
            {
                btn.Text = "3";
            }
            if (winscore>=15)
            {
                btn.Enabled = true;
            }
        }
        private void btn_firstcomputer_Click(object sender, EventArgs e)
        {
            play();
            btn_increaseone.Enabled = true;
            btn_increasetwo.Enabled = true;
            if (winscore>=15)
            {
                btn.Enabled = true;
            }
        }

        private void btn_increaseone_Click(object sender, EventArgs e)
        {
            main_score++;
            lbl_playerscore.Text = main_score.ToString();
            lbl_mainscore.Text = main_score.ToString();
            if (main_score>=winscore)
            {
                MessageBox.Show("You won!");
            }
            else
            {
                play();
            }
            
        }

        private void btn_increasetwo_Click(object sender, EventArgs e)
        {
            main_score += 2;         
            if (main_score >= winscore)
            {
                lbl_mainscore.Text = winscore.ToString();
                lbl_playerscore.Text = winscore.ToString();
                MessageBox.Show("You won!");
                btn_increaseone.Enabled = false;
                btn_increasetwo.Enabled = false;
                
            }
            else
            {
                lbl_playerscore.Text = main_score.ToString();
                lbl_mainscore.Text = main_score.ToString();
                play();
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
