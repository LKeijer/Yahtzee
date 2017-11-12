namespace Yahtzee
{
    partial class dice
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
            this.dice1 = new System.Windows.Forms.PictureBox();
            this.dice2 = new System.Windows.Forms.PictureBox();
            this.dice3 = new System.Windows.Forms.PictureBox();
            this.dice4 = new System.Windows.Forms.PictureBox();
            this.dice5 = new System.Windows.Forms.PictureBox();
            this.rollDice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice5)).BeginInit();
            this.SuspendLayout();
            // 
            // dice1
            // 
            this.dice1.Image = global::Yahtzee.Properties.Resources.dice1_6;
            this.dice1.Location = new System.Drawing.Point(33, 68);
            this.dice1.Name = "dice1";
            this.dice1.Size = new System.Drawing.Size(100, 100);
            this.dice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dice1.TabIndex = 0;
            this.dice1.TabStop = false;
            // 
            // dice2
            // 
            this.dice2.Image = global::Yahtzee.Properties.Resources.dice1_6;
            this.dice2.Location = new System.Drawing.Point(176, 68);
            this.dice2.Name = "dice2";
            this.dice2.Size = new System.Drawing.Size(100, 100);
            this.dice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dice2.TabIndex = 1;
            this.dice2.TabStop = false;
            // 
            // dice3
            // 
            this.dice3.Image = global::Yahtzee.Properties.Resources.dice1_6;
            this.dice3.Location = new System.Drawing.Point(336, 68);
            this.dice3.Name = "dice3";
            this.dice3.Size = new System.Drawing.Size(100, 100);
            this.dice3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dice3.TabIndex = 2;
            this.dice3.TabStop = false;
            // 
            // dice4
            // 
            this.dice4.Image = global::Yahtzee.Properties.Resources.dice1_6;
            this.dice4.Location = new System.Drawing.Point(501, 68);
            this.dice4.Name = "dice4";
            this.dice4.Size = new System.Drawing.Size(100, 100);
            this.dice4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dice4.TabIndex = 3;
            this.dice4.TabStop = false;
            // 
            // dice5
            // 
            this.dice5.Image = global::Yahtzee.Properties.Resources.dice1_6;
            this.dice5.Location = new System.Drawing.Point(682, 68);
            this.dice5.Name = "dice5";
            this.dice5.Size = new System.Drawing.Size(100, 100);
            this.dice5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dice5.TabIndex = 4;
            this.dice5.TabStop = false;
            // 
            // rollDice
            // 
            this.rollDice.AutoSize = true;
            this.rollDice.BackgroundImage = global::Yahtzee.Properties.Resources.rollDice;
            this.rollDice.Location = new System.Drawing.Point(336, 267);
            this.rollDice.Name = "rollDice";
            this.rollDice.Size = new System.Drawing.Size(144, 133);
            this.rollDice.TabIndex = 5;
            this.rollDice.Text = "ROLL";
            this.rollDice.UseVisualStyleBackColor = true;
            this.rollDice.Click += new System.EventHandler(this.rollDice_Click);
            // 
            // dice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 604);
            this.Controls.Add(this.rollDice);
            this.Controls.Add(this.dice5);
            this.Controls.Add(this.dice4);
            this.Controls.Add(this.dice3);
            this.Controls.Add(this.dice2);
            this.Controls.Add(this.dice1);
            this.Name = "dice";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.dice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox dice1;
        private System.Windows.Forms.PictureBox dice2;
        private System.Windows.Forms.PictureBox dice3;
        private System.Windows.Forms.PictureBox dice4;
        private System.Windows.Forms.PictureBox dice5;
        private System.Windows.Forms.Button rollDice;
    }
}

