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
    public partial class frmMakeReservation : Form, IMakeReservationView
    {
        private IMakeReservationController _makeReservationController;
        private Book _book;

        public frmMakeReservation(IMakeReservationController makeReservationController)
        {
            _makeReservationController = makeReservationController;

            InitializeComponent();
        }

        public void ShowModaless(IList<Library> libraries, Book book)
        {
            _book = book;

            foreach (Library library in libraries)
            {
                string text = library.Name + ", " + library.Address;
                ListViewItem item = new ListViewItem
                {
                    Text = text,
                    Tag = text
                };
                listViewLibraries.Items.Add(item);
            }

            Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listViewLibraries_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonReservation.Enabled = listViewLibraries.SelectedItems.Count == 1;
        }

        private void buttonReservation_Click(object sender, EventArgs e)
        {
            String selected = listViewLibraries.SelectedItems[0].Text;
            string[] split = selected.Split(',');
            string libraryName = split[0].Trim();
            string libraryAddress = split[1].Trim()+ ", " + split[2].Trim();

            if (_makeReservationController.MakeReservation(libraryName, libraryAddress, _book, this))
            {
                MessageBox.Show("Knjiga uspješno rezervirana u odabranoj knjižnici!");
                Close();
            }
        }

        public void NotifyOfReservedBook(Book book)
        {
            MessageBox.Show("Knjiga: " + book.BookDetails.Title + " je već rezervirana u odabranoj knjižnici");
        }
    }
}
