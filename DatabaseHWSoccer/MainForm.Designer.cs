namespace DatabaseHWSoccer
{
    partial class MainForm
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
            this.showPlayersButton = new System.Windows.Forms.Button();
            this.showCoachesButton = new System.Windows.Forms.Button();
            this.teamAndCoachesButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // showPlayersButton
            // 
            this.showPlayersButton.Location = new System.Drawing.Point(46, 130);
            this.showPlayersButton.Name = "showPlayersButton";
            this.showPlayersButton.Size = new System.Drawing.Size(120, 118);
            this.showPlayersButton.TabIndex = 0;
            this.showPlayersButton.Text = "Show Players";
            this.showPlayersButton.UseVisualStyleBackColor = true;
            this.showPlayersButton.Click += new System.EventHandler(this.showPlayersButton_Click);
            // 
            // showCoachesButton
            // 
            this.showCoachesButton.Location = new System.Drawing.Point(207, 130);
            this.showCoachesButton.Name = "showCoachesButton";
            this.showCoachesButton.Size = new System.Drawing.Size(120, 118);
            this.showCoachesButton.TabIndex = 1;
            this.showCoachesButton.Text = "Show Coaches";
            this.showCoachesButton.UseVisualStyleBackColor = true;
            // 
            // teamAndCoachesButton
            // 
            this.teamAndCoachesButton.Location = new System.Drawing.Point(375, 130);
            this.teamAndCoachesButton.Name = "teamAndCoachesButton";
            this.teamAndCoachesButton.Size = new System.Drawing.Size(120, 118);
            this.teamAndCoachesButton.TabIndex = 2;
            this.teamAndCoachesButton.Text = "Team and Coaches";
            this.teamAndCoachesButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Soccer Database Application";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(532, 339);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.teamAndCoachesButton);
            this.Controls.Add(this.showCoachesButton);
            this.Controls.Add(this.showPlayersButton);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showPlayersButton;
        private System.Windows.Forms.Button showCoachesButton;
        private System.Windows.Forms.Button teamAndCoachesButton;
        private System.Windows.Forms.Label label1;
    }
}

