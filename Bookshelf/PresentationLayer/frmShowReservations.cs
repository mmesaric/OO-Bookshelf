using BaseLib;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class frmShowReservations : Form, IShowReservationsView
    {
        IShowReservationsController _showReservationsController;

        public frmShowReservations(IShowReservationsController showReservationsController) 
        {
            _showReservationsController = showReservationsController;

            InitializeComponent();
        }

        public void showModaless(IList<Book> books)
        {
            foreach (Book book in books)
            {
                string text = book.BookDetails.Title + ", " + book.BookDetails.Author  + ", " + book.BookDetails.Publisher + 
                    ", " + book.BookDetails.YearPublished + ", " + book.Library.Name + ", " + book.Library.Address; 
                ListViewItem item = new ListViewItem
                {
                    Text = text,
                    Tag = book
                };
                listViewReservations.Items.Add(item);
            }

            Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonRemoveReservation_Click(object sender, EventArgs e)
        {
            var book = (Book) listViewReservations.SelectedItems[0].Tag;
            _showReservationsController.DeleteReservation(book);

            listViewReservations.Items.Remove(listViewReservations.SelectedItems[0]);
            MessageBox.Show("Uspješno se obrisali rezervaciju.");
        }

        private void listViewReservations_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonRemoveReservation.Enabled = listViewReservations.SelectedItems.Count == 1;
        }
    }
}
