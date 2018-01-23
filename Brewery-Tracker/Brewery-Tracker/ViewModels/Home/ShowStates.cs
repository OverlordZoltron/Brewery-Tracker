using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Globalization;
using System.Web.Mvc;

namespace Brewery_Tracker.ViewModels.Home
{
    public class ShowStates
    {
        public ShowLanguagesViewModel(CultureInfo[] cultures)
        {
            CulturesList = cultures.Select(c => new SelectListItem() { Text = c.EnglishName });
        }
        public IEnumerable<SelectListItem> CulturesList
        {
            get;
            private set;
        }
    }
}