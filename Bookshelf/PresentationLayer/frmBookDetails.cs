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
    public partial class frmBookDetails : Form, IBookDetailsView
    {
        private IBookDetailsController _bookDetailsController;

        public frmBookDetails(IBookDetailsController bookDetailsController)
        {
            _bookDetailsController = bookDetailsController;
            InitializeComponent();
        }

        public void ShowModaless(Book book)
        {
            labelBookTitle.Text = book.BookDetails.Title;
            labelAuthor.Text = "Autor: " + book.BookDetails.Author;
            labelPublisher.Text = "Izdavač: " + book.BookDetails.Publisher;
            labelYearPublished.Text = "Godina izdanja: " + book.BookDetails.YearPublished.ToString();
            labelGenre.Text = "Žanr: " + book.BookDetails.Genre;
            labelDescription.Text = book.BookDetails.Description;
            Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
