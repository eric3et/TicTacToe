
namespace TicTacToe
{
    partial class MainMenuPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSinglePlayer = new System.Windows.Forms.Button();
            this.btnLocalMulti = new System.Windows.Forms.Button();
            this.btnOnlineMulti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(60, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tic Tac Toe";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSinglePlayer
            // 
            this.btnSinglePlayer.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSinglePlayer.Location = new System.Drawing.Point(60, 179);
            this.btnSinglePlayer.Name = "btnSinglePlayer";
            this.btnSinglePlayer.Size = new System.Drawing.Size(252, 59);
            this.btnSinglePlayer.TabIndex = 1;
            this.btnSinglePlayer.TabStop = false;
            this.btnSinglePlayer.Text = "Singleplayer";
            this.btnSinglePlayer.UseVisualStyleBackColor = true;
            this.btnSinglePlayer.Click += new System.EventHandler(this.btnSinglePlayer_Click);
            // 
            // btnLocalMulti
            // 
            this.btnLocalMulti.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLocalMulti.Location = new System.Drawing.Point(60, 259);
            this.btnLocalMulti.Name = "btnLocalMulti";
            this.btnLocalMulti.Size = new System.Drawing.Size(252, 59);
            this.btnLocalMulti.TabIndex = 2;
            this.btnLocalMulti.TabStop = false;
            this.btnLocalMulti.Text = "Local Multiplayer";
            this.btnLocalMulti.UseVisualStyleBackColor = true;
            this.btnLocalMulti.Click += new System.EventHandler(this.btnLocalMulti_Click);
            // 
            // btnOnlineMulti
            // 
            this.btnOnlineMulti.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOnlineMulti.Location = new System.Drawing.Point(60, 340);
            this.btnOnlineMulti.Name = "btnOnlineMulti";
            this.btnOnlineMulti.Size = new System.Drawing.Size(252, 59);
            this.btnOnlineMulti.TabIndex = 3;
            this.btnOnlineMulti.TabStop = false;
            this.btnOnlineMulti.Text = "Online MultiPlayer";
            this.btnOnlineMulti.UseVisualStyleBackColor = true;
            this.btnOnlineMulti.Click += new System.EventHandler(this.btnOnlineMulti_Click);
            // 
            // MainMenuPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 451);
            this.Controls.Add(this.btnOnlineMulti);
            this.Controls.Add(this.btnLocalMulti);
            this.Controls.Add(this.btnSinglePlayer);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(382, 490);
            this.MinimumSize = new System.Drawing.Size(382, 490);
            this.Name = "MainMenuPage";
            this.Text = "TIC-TAC-TOE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSinglePlayer;
        private System.Windows.Forms.Button btnLocalMulti;
        private System.Windows.Forms.Button btnOnlineMulti;
    }
}