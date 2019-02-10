namespace PresentationLayer
{
    partial class frmBookDetails
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
            this.labelBookTitle = new System.Windows.Forms.Label();
            this.labelPublisher = new System.Windows.Forms.Label();
            this.labelYearPublished = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelBookTitle
            // 
            this.labelBookTitle.AutoSize = true;
            this.labelBookTitle.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBookTitle.Location = new System.Drawing.Point(37, 29);
            this.labelBookTitle.Name = "labelBookTitle";
            this.labelBookTitle.Size = new System.Drawing.Size(89, 33);
            this.labelBookTitle.TabIndex = 0;
            this.labelBookTitle.Text = "Naslov";
            this.labelBookTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPublisher
            // 
            this.labelPublisher.AutoSize = true;
            this.labelPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPublisher.Location = new System.Drawing.Point(40, 98);
            this.labelPublisher.Name = "labelPublisher";
            this.labelPublisher.Size = new System.Drawing.Size(55, 16);
            this.labelPublisher.TabIndex = 1;
            this.labelPublisher.Text = "Izdavač";
            // 
            // labelYearPublished
            // 
            this.labelYearPublished.AutoSize = true;
            this.labelYearPublished.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelYearPublished.Location = new System.Drawing.Point(40, 117);
            this.labelYearPublished.Name = "labelYearPublished";
            this.labelYearPublished.Size = new System.Drawing.Size(52, 16);
            this.labelYearPublished.TabIndex = 2;
            this.labelYearPublished.Text = "Godina";
            // 
            // labelDescription
            // 
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDescription.Location = new System.Drawing.Point(39, 182);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(650, 126);
            this.labelDescription.TabIndex = 3;
            this.labelDescription.Text = "Opis";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAuthor.Location = new System.Drawing.Point(40, 79);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(39, 16);
            this.labelAuthor.TabIndex = 4;
            this.labelAuthor.Text = "Autor";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGenre.Location = new System.Drawing.Point(40, 137);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(35, 16);
            this.labelGenre.TabIndex = 5;
            this.labelGenre.Text = "Žanr";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(322, 311);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 6;
            this.buttonBack.Text = "Povratak";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // frmBookDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(724, 367);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelYearPublished);
            this.Controls.Add(this.labelPublisher);
            this.Controls.Add(this.labelBookTitle);
            this.Name = "frmBookDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalji o knjizi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBookTitle;
        private System.Windows.Forms.Label labelPublisher;
        private System.Windows.Forms.Label labelYearPublished;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Button buttonBack;
    }
}