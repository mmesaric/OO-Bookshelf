namespace PresentationLayer
{
    partial class frmLobby
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
            this.greetingLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.searchResultsListView = new System.Windows.Forms.ListView();
            this.viewDetailsButton = new System.Windows.Forms.Button();
            this.checkAvailabilityButton = new System.Windows.Forms.Button();
            this.buttonShowReservations = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // greetingLabel
            // 
            this.greetingLabel.AutoSize = true;
            this.greetingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.greetingLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.greetingLabel.Location = new System.Drawing.Point(314, 47);
            this.greetingLabel.Name = "greetingLabel";
            this.greetingLabel.Size = new System.Drawing.Size(122, 20);
            this.greetingLabel.TabIndex = 0;
            this.greetingLabel.Text = "Pretražite knjige";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.searchTextBox.Location = new System.Drawing.Point(200, 87);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(350, 23);
            this.searchTextBox.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(337, 123);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Traži";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchBarClick);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(616, 49);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 23);
            this.logoutButton.TabIndex = 3;
            this.logoutButton.Text = "Odjavite se";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(613, 33);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(44, 13);
            this.usernameLabel.TabIndex = 5;
            this.usernameLabel.Text = "Korisnik";
            // 
            // searchResultsListView
            // 
            this.searchResultsListView.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.searchResultsListView.FullRowSelect = true;
            this.searchResultsListView.GridLines = true;
            this.searchResultsListView.Location = new System.Drawing.Point(42, 187);
            this.searchResultsListView.Name = "searchResultsListView";
            this.searchResultsListView.Size = new System.Drawing.Size(649, 125);
            this.searchResultsListView.TabIndex = 6;
            this.searchResultsListView.UseCompatibleStateImageBehavior = false;
            this.searchResultsListView.View = System.Windows.Forms.View.List;
            this.searchResultsListView.SelectedIndexChanged += new System.EventHandler(this.selectedIndexChanged_BooksListView);
            this.searchResultsListView.Leave += new System.EventHandler(this.listViewSearchResults_LeaveFocus);
            // 
            // viewDetailsButton
            // 
            this.viewDetailsButton.Enabled = false;
            this.viewDetailsButton.Location = new System.Drawing.Point(200, 325);
            this.viewDetailsButton.Name = "viewDetailsButton";
            this.viewDetailsButton.Size = new System.Drawing.Size(96, 23);
            this.viewDetailsButton.TabIndex = 7;
            this.viewDetailsButton.Text = "Pogledaj detalje";
            this.viewDetailsButton.UseVisualStyleBackColor = true;
            this.viewDetailsButton.Click += new System.EventHandler(this.viewDetailsButton_Click);
            // 
            // checkAvailabilityButton
            // 
            this.checkAvailabilityButton.Enabled = false;
            this.checkAvailabilityButton.Location = new System.Drawing.Point(434, 325);
            this.checkAvailabilityButton.Name = "checkAvailabilityButton";
            this.checkAvailabilityButton.Size = new System.Drawing.Size(116, 23);
            this.checkAvailabilityButton.TabIndex = 8;
            this.checkAvailabilityButton.Text = "Provjerite dostupnost";
            this.checkAvailabilityButton.UseVisualStyleBackColor = true;
            this.checkAvailabilityButton.Click += new System.EventHandler(this.checkAvailabilityButton_Click);
            // 
            // buttonShowReservations
            // 
            this.buttonShowReservations.Location = new System.Drawing.Point(42, 49);
            this.buttonShowReservations.Name = "buttonShowReservations";
            this.buttonShowReservations.Size = new System.Drawing.Size(96, 23);
            this.buttonShowReservations.TabIndex = 9;
            this.buttonShowReservations.Text = "Vaše rezervacije";
            this.buttonShowReservations.UseVisualStyleBackColor = true;
            this.buttonShowReservations.Click += new System.EventHandler(this.buttonShowReservations_Click);
            // 
            // frmLobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(724, 367);
            this.Controls.Add(this.buttonShowReservations);
            this.Controls.Add(this.checkAvailabilityButton);
            this.Controls.Add(this.viewDetailsButton);
            this.Controls.Add(this.searchResultsListView);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.greetingLabel);
            this.Name = "frmLobby";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pretraga knjiga";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label greetingLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.ListView searchResultsListView;
        private System.Windows.Forms.Button viewDetailsButton;
        private System.Windows.Forms.Button checkAvailabilityButton;
        private System.Windows.Forms.Button buttonShowReservations;
    }
}