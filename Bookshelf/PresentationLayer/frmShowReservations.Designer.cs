namespace PresentationLayer
{
    partial class frmShowReservations
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
            this.buttonRemoveReservation = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewReservations = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // buttonRemoveReservation
            // 
            this.buttonRemoveReservation.Enabled = false;
            this.buttonRemoveReservation.Location = new System.Drawing.Point(605, 189);
            this.buttonRemoveReservation.Name = "buttonRemoveReservation";
            this.buttonRemoveReservation.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveReservation.TabIndex = 7;
            this.buttonRemoveReservation.Text = "Obriši";
            this.buttonRemoveReservation.UseVisualStyleBackColor = true;
            this.buttonRemoveReservation.Click += new System.EventHandler(this.buttonRemoveReservation_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(252, 291);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 6;
            this.buttonBack.Text = "Povratak";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(45, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 72);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pregled vaših rezerviranih knjiga\r\n\r\nU nastavku su prikazane knjige koje ste reze" +
    "rvirali.\r\nKako bi obrisali rezervaciju, odaberite knjigu i kliknite na gumb \"Obr" +
    "iši\".\r\n";
            // 
            // listViewReservations
            // 
            this.listViewReservations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewReservations.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listViewReservations.FullRowSelect = true;
            this.listViewReservations.GridLines = true;
            this.listViewReservations.Location = new System.Drawing.Point(48, 152);
            this.listViewReservations.Name = "listViewReservations";
            this.listViewReservations.Size = new System.Drawing.Size(497, 97);
            this.listViewReservations.TabIndex = 4;
            this.listViewReservations.UseCompatibleStateImageBehavior = false;
            this.listViewReservations.View = System.Windows.Forms.View.List;
            this.listViewReservations.SelectedIndexChanged += new System.EventHandler(this.listViewReservations_SelectedIndexChanged);
            // 
            // frmShowReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(724, 367);
            this.Controls.Add(this.buttonRemoveReservation);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewReservations);
            this.Name = "frmShowReservations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmShowReservations";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRemoveReservation;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewReservations;
    }
}