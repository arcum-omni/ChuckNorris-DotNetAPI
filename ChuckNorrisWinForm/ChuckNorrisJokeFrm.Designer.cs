namespace ChuckNorrisWinForm
{
    partial class ChuckNorrisJokeFrm
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
            this.randomJokeBtn = new System.Windows.Forms.Button();
            this.randomJokeRtx = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // randomJokeBtn
            // 
            this.randomJokeBtn.Location = new System.Drawing.Point(267, 190);
            this.randomJokeBtn.Name = "randomJokeBtn";
            this.randomJokeBtn.Size = new System.Drawing.Size(242, 111);
            this.randomJokeBtn.TabIndex = 0;
            this.randomJokeBtn.Text = "Get Random Joke";
            this.randomJokeBtn.UseVisualStyleBackColor = true;
            this.randomJokeBtn.Click += new System.EventHandler(this.randomJokeBtn_Click);
            // 
            // randomJokeRtx
            // 
            this.randomJokeRtx.Location = new System.Drawing.Point(35, 325);
            this.randomJokeRtx.Name = "randomJokeRtx";
            this.randomJokeRtx.Size = new System.Drawing.Size(734, 96);
            this.randomJokeRtx.TabIndex = 2;
            this.randomJokeRtx.Text = "";
            // 
            // ChuckNorrisJokeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.randomJokeRtx);
            this.Controls.Add(this.randomJokeBtn);
            this.Name = "ChuckNorrisJokeFrm";
            this.Text = "Chuck Norris Joke Generator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button randomJokeBtn;
        private System.Windows.Forms.RichTextBox randomJokeRtx;
    }
}

