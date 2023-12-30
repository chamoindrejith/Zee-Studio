namespace The_Zee_Studio
{
    partial class Display
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
            this.lblProductionCompany = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.lblReview = new System.Windows.Forms.Label();
            this.lblMovieID = new System.Windows.Forms.Label();
            this.lblMovieName = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProductionCompany
            // 
            this.lblProductionCompany.AutoSize = true;
            this.lblProductionCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductionCompany.Location = new System.Drawing.Point(93, 275);
            this.lblProductionCompany.Name = "lblProductionCompany";
            this.lblProductionCompany.Size = new System.Drawing.Size(132, 16);
            this.lblProductionCompany.TabIndex = 1;
            this.lblProductionCompany.Text = "Production Company";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(93, 240);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 16);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email ID";
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirector.Location = new System.Drawing.Point(93, 205);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(54, 16);
            this.lblDirector.TabIndex = 3;
            this.lblDirector.Text = "Director";
            // 
            // lblReview
            // 
            this.lblReview.AutoSize = true;
            this.lblReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReview.Location = new System.Drawing.Point(92, 166);
            this.lblReview.Name = "lblReview";
            this.lblReview.Size = new System.Drawing.Size(52, 16);
            this.lblReview.TabIndex = 4;
            this.lblReview.Text = "Review";
            // 
            // lblMovieID
            // 
            this.lblMovieID.AutoSize = true;
            this.lblMovieID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieID.Location = new System.Drawing.Point(90, 130);
            this.lblMovieID.Name = "lblMovieID";
            this.lblMovieID.Size = new System.Drawing.Size(60, 16);
            this.lblMovieID.TabIndex = 5;
            this.lblMovieID.Text = "Movie ID";
            // 
            // lblMovieName
            // 
            this.lblMovieName.AutoSize = true;
            this.lblMovieName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieName.Location = new System.Drawing.Point(90, 92);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(84, 16);
            this.lblMovieName.TabIndex = 6;
            this.lblMovieName.Text = "Movie Name";
            // 
            // btnOk
            // 
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOk.Location = new System.Drawing.Point(219, 341);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(108, 42);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(567, 442);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblProductionCompany);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblDirector);
            this.Controls.Add(this.lblReview);
            this.Controls.Add(this.lblMovieID);
            this.Controls.Add(this.lblMovieName);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "Display";
            this.Text = "Display";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductionCompany;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label lblReview;
        private System.Windows.Forms.Label lblMovieID;
        private System.Windows.Forms.Label lblMovieName;
        private System.Windows.Forms.Button btnOk;
    }
}