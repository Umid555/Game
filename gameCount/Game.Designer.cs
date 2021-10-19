namespace gameCount
{
    partial class Game
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.tb_winpoint = new System.Windows.Forms.TextBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.lbl_playerscore = new System.Windows.Forms.Label();
            this.btn_firstplayer = new System.Windows.Forms.Button();
            this.btn_firstcomputer = new System.Windows.Forms.Button();
            this.lbl_mainscore = new System.Windows.Forms.Label();
            this.lbl_computerscore = new System.Windows.Forms.Label();
            this.lbl_playertext = new System.Windows.Forms.Label();
            this.lbl_computertext = new System.Windows.Forms.Label();
            this.lbl_mainscoretext = new System.Windows.Forms.Label();
            this.btn_increaseone = new System.Windows.Forms.Button();
            this.btn_increasetwo = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_winpoint
            // 
            this.tb_winpoint.Location = new System.Drawing.Point(95, 22);
            this.tb_winpoint.Name = "tb_winpoint";
            this.tb_winpoint.Size = new System.Drawing.Size(100, 38);
            this.tb_winpoint.TabIndex = 0;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(231, 22);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(101, 38);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // lbl_playerscore
            // 
            this.lbl_playerscore.AutoSize = true;
            this.lbl_playerscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_playerscore.ForeColor = System.Drawing.Color.Navy;
            this.lbl_playerscore.Location = new System.Drawing.Point(736, 277);
            this.lbl_playerscore.Name = "lbl_playerscore";
            this.lbl_playerscore.Size = new System.Drawing.Size(52, 55);
            this.lbl_playerscore.TabIndex = 2;
            this.lbl_playerscore.Text = "0";
            // 
            // btn_firstplayer
            // 
            this.btn_firstplayer.Enabled = false;
            this.btn_firstplayer.Location = new System.Drawing.Point(646, 11);
            this.btn_firstplayer.Name = "btn_firstplayer";
            this.btn_firstplayer.Size = new System.Drawing.Size(224, 49);
            this.btn_firstplayer.TabIndex = 3;
            this.btn_firstplayer.Text = "First me";
            this.btn_firstplayer.UseVisualStyleBackColor = true;
            this.btn_firstplayer.Click += new System.EventHandler(this.btn_firstplayer_Click);
            // 
            // btn_firstcomputer
            // 
            this.btn_firstcomputer.Enabled = false;
            this.btn_firstcomputer.Location = new System.Drawing.Point(646, 66);
            this.btn_firstcomputer.Name = "btn_firstcomputer";
            this.btn_firstcomputer.Size = new System.Drawing.Size(224, 49);
            this.btn_firstcomputer.TabIndex = 4;
            this.btn_firstcomputer.Text = "First computer";
            this.btn_firstcomputer.UseVisualStyleBackColor = true;
            this.btn_firstcomputer.Click += new System.EventHandler(this.btn_firstcomputer_Click);
            // 
            // lbl_mainscore
            // 
            this.lbl_mainscore.AutoSize = true;
            this.lbl_mainscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_mainscore.Location = new System.Drawing.Point(424, 181);
            this.lbl_mainscore.Name = "lbl_mainscore";
            this.lbl_mainscore.Size = new System.Drawing.Size(52, 55);
            this.lbl_mainscore.TabIndex = 5;
            this.lbl_mainscore.Text = "0";
            // 
            // lbl_computerscore
            // 
            this.lbl_computerscore.AutoSize = true;
            this.lbl_computerscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_computerscore.ForeColor = System.Drawing.Color.Red;
            this.lbl_computerscore.Location = new System.Drawing.Point(85, 277);
            this.lbl_computerscore.Name = "lbl_computerscore";
            this.lbl_computerscore.Size = new System.Drawing.Size(52, 55);
            this.lbl_computerscore.TabIndex = 6;
            this.lbl_computerscore.Text = "0";
            // 
            // lbl_playertext
            // 
            this.lbl_playertext.AutoSize = true;
            this.lbl_playertext.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_playertext.ForeColor = System.Drawing.Color.Navy;
            this.lbl_playertext.Location = new System.Drawing.Point(691, 222);
            this.lbl_playertext.Name = "lbl_playertext";
            this.lbl_playertext.Size = new System.Drawing.Size(127, 55);
            this.lbl_playertext.TabIndex = 7;
            this.lbl_playertext.Text = "You:";
            // 
            // lbl_computertext
            // 
            this.lbl_computertext.AutoSize = true;
            this.lbl_computertext.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_computertext.ForeColor = System.Drawing.Color.Red;
            this.lbl_computertext.Location = new System.Drawing.Point(12, 222);
            this.lbl_computertext.Name = "lbl_computertext";
            this.lbl_computertext.Size = new System.Drawing.Size(258, 55);
            this.lbl_computertext.TabIndex = 8;
            this.lbl_computertext.Text = "Computer:";
            // 
            // lbl_mainscoretext
            // 
            this.lbl_mainscoretext.AutoSize = true;
            this.lbl_mainscoretext.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_mainscoretext.Location = new System.Drawing.Point(379, 126);
            this.lbl_mainscoretext.Name = "lbl_mainscoretext";
            this.lbl_mainscoretext.Size = new System.Drawing.Size(146, 55);
            this.lbl_mainscoretext.TabIndex = 9;
            this.lbl_mainscoretext.Text = "Main:";
            // 
            // btn_increaseone
            // 
            this.btn_increaseone.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_increaseone.Enabled = false;
            this.btn_increaseone.Location = new System.Drawing.Point(271, 363);
            this.btn_increaseone.Name = "btn_increaseone";
            this.btn_increaseone.Size = new System.Drawing.Size(164, 49);
            this.btn_increaseone.TabIndex = 10;
            this.btn_increaseone.Text = "+1";
            this.btn_increaseone.UseVisualStyleBackColor = false;
            this.btn_increaseone.Click += new System.EventHandler(this.btn_increaseone_Click);
            // 
            // btn_increasetwo
            // 
            this.btn_increasetwo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_increasetwo.Enabled = false;
            this.btn_increasetwo.Location = new System.Drawing.Point(452, 363);
            this.btn_increasetwo.Name = "btn_increasetwo";
            this.btn_increasetwo.Size = new System.Drawing.Size(164, 49);
            this.btn_increasetwo.TabIndex = 11;
            this.btn_increasetwo.Text = "+2";
            this.btn_increasetwo.UseVisualStyleBackColor = false;
            this.btn_increasetwo.Click += new System.EventHandler(this.btn_increasetwo_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(412, 22);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(101, 38);
            this.btn_reset.TabIndex = 12;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(892, 454);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_increasetwo);
            this.Controls.Add(this.btn_increaseone);
            this.Controls.Add(this.lbl_mainscoretext);
            this.Controls.Add(this.lbl_computertext);
            this.Controls.Add(this.lbl_playertext);
            this.Controls.Add(this.lbl_computerscore);
            this.Controls.Add(this.lbl_mainscore);
            this.Controls.Add(this.btn_firstcomputer);
            this.Controls.Add(this.btn_firstplayer);
            this.Controls.Add(this.lbl_playerscore);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.tb_winpoint);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Game";
            this.Text = "Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_winpoint;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label lbl_playerscore;
        private System.Windows.Forms.Button btn_firstplayer;
        private System.Windows.Forms.Button btn_firstcomputer;
        private System.Windows.Forms.Label lbl_mainscore;
        private System.Windows.Forms.Label lbl_computerscore;
        private System.Windows.Forms.Label lbl_playertext;
        private System.Windows.Forms.Label lbl_computertext;
        private System.Windows.Forms.Label lbl_mainscoretext;
        private System.Windows.Forms.Button btn_increaseone;
        private System.Windows.Forms.Button btn_increasetwo;
        private System.Windows.Forms.Button btn_reset;
    }
}

