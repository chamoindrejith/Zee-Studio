namespace The_Zee_Studio
{
    partial class Movie
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
            this.lblMovieName = new System.Windows.Forms.Label();
            this.lblMovieID = new System.Windows.Forms.Label();
            this.blReview = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblProductionCompany = new System.Windows.Forms.Label();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.txtMovieID = new System.Windows.Forms.TextBox();
            this.txtReview = new System.Windows.Forms.TextBox();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.txtEmailID = new System.Windows.Forms.TextBox();
            this.txtProductionCompany = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMovieName
            // 
            this.lblMovieName.AutoSize = true;
            this.lblMovieName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieName.Location = new System.Drawing.Point(78, 79);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(84, 16);
            this.lblMovieName.TabIndex = 0;
            this.lblMovieName.Text = "Movie Name";
            // 
            // lblMovieID
            // 
            this.lblMovieID.AutoSize = true;
            this.lblMovieID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieID.Location = new System.Drawing.Point(78, 117);
            this.lblMovieID.Name = "lblMovieID";
            this.lblMovieID.Size = new System.Drawing.Size(60, 16);
            this.lblMovieID.TabIndex = 0;
            this.lblMovieID.Text = "Movie ID";
            // 
            // blReview
            // 
            this.blReview.AutoSize = true;
            this.blReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blReview.Location = new System.Drawing.Point(80, 153);
            this.blReview.Name = "blReview";
            this.blReview.Size = new System.Drawing.Size(52, 16);
            this.blReview.TabIndex = 0;
            this.blReview.Text = "Review";
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirector.Location = new System.Drawing.Point(78, 241);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(54, 16);
            this.lblDirector.TabIndex = 0;
            this.lblDirector.Text = "Director";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(78, 276);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 16);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email ID";
            // 
            // lblProductionCompany
            // 
            this.lblProductionCompany.AutoSize = true;
            this.lblProductionCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductionCompany.Location = new System.Drawing.Point(78, 311);
            this.lblProductionCompany.Name = "lblProductionCompany";
            this.lblProductionCompany.Size = new System.Drawing.Size(132, 16);
            this.lblProductionCompany.TabIndex = 0;
            this.lblProductionCompany.Text = "Production Company";
            // 
            // txtMovieName
            // 
            this.txtMovieName.Location = new System.Drawing.Point(248, 76);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(245, 21);
            this.txtMovieName.TabIndex = 1;
            // 
            // txtMovieID
            // 
            this.txtMovieID.Location = new System.Drawing.Point(248, 114);
            this.txtMovieID.Name = "txtMovieID";
            this.txtMovieID.Size = new System.Drawing.Size(245, 21);
            this.txtMovieID.TabIndex = 1;
            // 
            // txtReview
            // 
            this.txtReview.Location = new System.Drawing.Point(248, 150);
            this.txtReview.Multiline = true;
            this.txtReview.Name = "txtReview";
            this.txtReview.Size = new System.Drawing.Size(245, 72);
            this.txtReview.TabIndex = 1;
            // 
            // txtDirector
            // 
            this.txtDirector.Location = new System.Drawing.Point(248, 238);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(245, 21);
            this.txtDirector.TabIndex = 1;
            // 
            // txtEmailID
            // 
            this.txtEmailID.Location = new System.Drawing.Point(248, 276);
            this.txtEmailID.Name = "txtEmailID";
            this.txtEmailID.Size = new System.Drawing.Size(245, 21);
            this.txtEmailID.TabIndex = 1;
            // 
            // txtProductionCompany
            // 
            this.txtProductionCompany.Location = new System.Drawing.Point(248, 311);
            this.txtProductionCompany.Name = "txtProductionCompany";
            this.txtProductionCompany.Size = new System.Drawing.Size(245, 21);
            this.txtProductionCompany.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSubmit.Location = new System.Drawing.Point(341, 368);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(108, 42);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClose.Location = new System.Drawing.Point(130, 368);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(108, 42);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Movie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(567, 442);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtProductionCompany);
            this.Controls.Add(this.txtEmailID);
            this.Controls.Add(this.txtDirector);
            this.Controls.Add(this.txtReview);
            this.Controls.Add(this.txtMovieID);
            this.Controls.Add(this.txtMovieName);
            this.Controls.Add(this.lblProductionCompany);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblDirector);
            this.Controls.Add(this.blReview);
            this.Controls.Add(this.lblMovieID);
            this.Controls.Add(this.lblMovieName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Movie";
            this.Text = "Movie";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMovieName;
        private System.Windows.Forms.Label lblMovieID;
        private System.Windows.Forms.Label blReview;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblProductionCompany;
        private System.Windows.Forms.TextBox txtMovieName;
        private System.Windows.Forms.TextBox txtMovieID;
        private System.Windows.Forms.TextBox txtReview;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.TextBox txtEmailID;
        private System.Windows.Forms.TextBox txtProductionCompany;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnClose;
    }
}