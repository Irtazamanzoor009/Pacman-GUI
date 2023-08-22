
namespace PacManGUI
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.gameLoop = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.BarTankHealth = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.BarHorizontalEnemyHealth = new System.Windows.Forms.ProgressBar();
            this.BarVerticalEnemyHealth = new System.Windows.Forms.ProgressBar();
            this.BarRandomEnemyHealth = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameLoop
            // 
            this.gameLoop.Enabled = true;
            this.gameLoop.Tick += new System.EventHandler(this.gameLoop_Tick);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.White;
            this.lblScore.ForeColor = System.Drawing.Color.Black;
            this.lblScore.Location = new System.Drawing.Point(11, 938);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(51, 20);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Score";
            // 
            // BarTankHealth
            // 
            this.BarTankHealth.BackColor = System.Drawing.Color.Azure;
            this.BarTankHealth.ForeColor = System.Drawing.SystemColors.Control;
            this.BarTankHealth.Location = new System.Drawing.Point(298, 935);
            this.BarTankHealth.Name = "BarTankHealth";
            this.BarTankHealth.Size = new System.Drawing.Size(208, 23);
            this.BarTankHealth.TabIndex = 1;
            this.BarTankHealth.Value = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(189, 938);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Player Health";
            // 
            // BarHorizontalEnemyHealth
            // 
            this.BarHorizontalEnemyHealth.Location = new System.Drawing.Point(666, 932);
            this.BarHorizontalEnemyHealth.Name = "BarHorizontalEnemyHealth";
            this.BarHorizontalEnemyHealth.Size = new System.Drawing.Size(130, 23);
            this.BarHorizontalEnemyHealth.TabIndex = 4;
            this.BarHorizontalEnemyHealth.Value = 100;
            // 
            // BarVerticalEnemyHealth
            // 
            this.BarVerticalEnemyHealth.Location = new System.Drawing.Point(974, 938);
            this.BarVerticalEnemyHealth.Name = "BarVerticalEnemyHealth";
            this.BarVerticalEnemyHealth.Size = new System.Drawing.Size(130, 23);
            this.BarVerticalEnemyHealth.TabIndex = 5;
            this.BarVerticalEnemyHealth.Value = 100;
            // 
            // BarRandomEnemyHealth
            // 
            this.BarRandomEnemyHealth.Location = new System.Drawing.Point(1279, 941);
            this.BarRandomEnemyHealth.Name = "BarRandomEnemyHealth";
            this.BarRandomEnemyHealth.Size = new System.Drawing.Size(130, 23);
            this.BarRandomEnemyHealth.TabIndex = 6;
            this.BarRandomEnemyHealth.Value = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(535, 935);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "H Enemy Health";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(844, 938);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "V Enemy Health";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(1148, 941);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "R Enemy Health";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::PacManGUI.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1732, 1005);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BarRandomEnemyHealth);
            this.Controls.Add(this.BarVerticalEnemyHealth);
            this.Controls.Add(this.BarHorizontalEnemyHealth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BarTankHealth);
            this.Controls.Add(this.lblScore);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameLoop;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.ProgressBar BarTankHealth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar BarHorizontalEnemyHealth;
        private System.Windows.Forms.ProgressBar BarVerticalEnemyHealth;
        private System.Windows.Forms.ProgressBar BarRandomEnemyHealth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

