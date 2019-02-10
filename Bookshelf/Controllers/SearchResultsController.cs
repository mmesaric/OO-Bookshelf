using BaseLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class SearchResultsController : ISearchResultsController
    {
        private IWindowFormsFactory _windowFormsFactory;

        public SearchResultsController(IWindowFormsFactory windowFormsFactory)
        {
            _windowFormsFactory = windowFormsFactory;
        }

        public void ViewSearchResults()
        {
            throw new NotImplementedException();
        }
    }
}
