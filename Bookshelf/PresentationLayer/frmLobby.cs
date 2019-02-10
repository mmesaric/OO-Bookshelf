using BaseLib;
using System;
using Controllers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model.Entities;

namespace PresentationLayer
{
    public partial class frmLobby : Form, ILobbyView
    {
        private IMainController _mainController;
        private ILobbyController _lobbyController;

        public frmLobby(IMainController mainController, ILobbyController lobbyController)
        {
            _mainController = mainController;
            _lobbyController = lobbyController;
            InitializeComponent();
        }

        public void ShowModaless(string signedInName)
        {
            usernameLabel.Text = "Dobrodošli " + signedInName;
            Show();
        }

        private void SearchBarClick(object sender, EventArgs e)
        {

            string searchText = searchTextBox.Text;
            if (searchText.Trim() == "")
            {
                MessageBox.Show("Unesite naslov knjige kako biste započeli pretragu.");
                return;
            }

            searchResultsListView.Clear();
            IList<Book> books = _lobbyController.SearchBooks(searchText);

            var filteredBooks = books
                 .GroupBy(book => new { book.BookDetails.Title,book.BookDetails.Author ,book.BookDetails.Publisher,
                                        book.BookDetails.YearPublished })
                 .Select(m => new { m.Key.Title, m.Key.Author , m.Key.Publisher, m.Key.YearPublished })
                 .ToList();

            foreach (var book in filteredBooks)
            {
                string text = book.Title + ", " + book.Author + ", " + book.Publisher + ", " + book.YearPublished;
                ListViewItem item = new ListViewItem
                {
                    Text = text,
                    Tag = text
                };
                searchResultsListView.Items.Add(item);
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            _mainController.Logout();
            Close();
        }

        private void selectedIndexChanged_BooksListView(object sender, EventArgs e)
        {
            checkAvailabilityButton.Enabled = searchResultsListView.SelectedItems.Count == 1;
            viewDetailsButton.Enabled = searchResultsListView.SelectedItems.Count == 1;
        }

        private void listViewSearchResults_LeaveFocus(object sender, EventArgs e)
        {
            //checkAvailabilityButton.Enabled = false;
            //viewDetailsButton.Enabled = false;
        }

        private void viewDetailsButton_Click(object sender, EventArgs e)
        {
            String selected = searchResultsListView.SelectedItems[0].Text;
            string[] split = selected.Split(',');
            string title = split[0].Trim();
            string publisher = split[2].Trim();
            string yearPublished = split[3].Trim();

            _lobbyController.ShowDetails(title, publisher, Convert.ToInt32(yearPublished));
        }

        private void checkAvailabilityButton_Click(object sender, EventArgs e)
        {
            String selected = searchResultsListView.SelectedItems[0].Text;
            string[] split = selected.Split(',');
            string title = split[0].Trim();
            string publisher = split[2].Trim();
            string yearPublished = split[3].Trim();

            _lobbyController.ShowMakeReservation(title, publisher, Convert.ToInt32(yearPublished));
        }

        private void buttonShowReservations_Click(object sender, EventArgs e)
        {
            _lobbyController.ShowViewReservations();
        }
    }
}
