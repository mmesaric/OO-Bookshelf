namespace PresentationLayer
{
    partial class frmMakeReservation
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
            this.listViewLibraries = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonReservation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewLibraries
            // 
            this.listViewLibraries.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewLibraries.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listViewLibraries.FullRowSelect = true;
            this.listViewLibraries.GridLines = true;
            this.listViewLibraries.Location = new System.Drawing.Point(42, 147);
            this.listViewLibraries.Name = "listViewLibraries";
            this.listViewLibraries.Size = new System.Drawing.Size(497, 97);
            this.listViewLibraries.TabIndex = 0;
            this.listViewLibraries.UseCompatibleStateImageBehavior = false;
            this.listViewLibraries.View = System.Windows.Forms.View.List;
            this.listViewLibraries.SelectedIndexChanged += new System.EventHandler(this.listViewLibraries_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(39, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 72);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pregled dostupnosti odabrane knjige\r\n\r\nU nastavku su navedene knjižnice koje imaj" +
    "u odabranu knjigu na raspolaganju.\r\nKako bi rezervirali knjigu, odaberite knjižn" +
    "icu i kliknite na gumb \"Rezerviraj\".\r\n";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(246, 286);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "Povratak";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonReservation
            // 
            this.buttonReservation.Enabled = false;
            this.buttonReservation.Location = new System.Drawing.Point(599, 184);
            this.buttonReservation.Name = "buttonReservation";
            this.buttonReservation.Size = new System.Drawing.Size(75, 23);
            this.buttonReservation.TabIndex = 3;
            this.buttonReservation.Text = "Rezerviraj";
            this.buttonReservation.UseVisualStyleBackColor = true;
            this.buttonReservation.Click += new System.EventHandler(this.buttonReservation_Click);
            // 
            // frmMakeReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(724, 367);
            this.Controls.Add(this.buttonReservation);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewLibraries);
            this.Name = "frmMakeReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezervacija";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewLibraries;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonReservation;
    }
}