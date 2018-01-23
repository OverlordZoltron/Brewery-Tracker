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
        public ShowStates()
        {
           StateList = GetStatesList();
        }

        public IEnumerable<string> StateList { get; private set; }


        public static IEnumerable<string> GetStatesList()
        {
            List<string> StateList = new List<string>();
            StateList.Add("Select One");
            StateList.Add("ALABAMA");
            StateList.Add("ALASKA");
            StateList.Add("ARIZONA");
            StateList.Add("ARKANSAS");
            StateList.Add("CALIFORNIA");
            StateList.Add("COLORADO");
            StateList.Add("CONNECTICUT");
            StateList.Add("DELAWARE");
            StateList.Add("FLORIDA");
            StateList.Add("GEORGIA");
            StateList.Add("HAWAII");
            StateList.Add("IDAHO");
            StateList.Add("ILLINOIS");
            StateList.Add("INDIANA");
            StateList.Add("IOWA");
            StateList.Add("KANSAS");
            StateList.Add("KENTUCKY");
            StateList.Add("LOUISIANA");
            StateList.Add("MAINE");
            StateList.Add("MARYLAND");
            StateList.Add("MASSACHUSETTS");
            StateList.Add("MICHIGAN");
            StateList.Add("MINNESOTA");
            StateList.Add("MISSISSIPPI");
            StateList.Add("MISSOURI");
            StateList.Add("MONTANA");
            StateList.Add("NEBRASKA");
            StateList.Add("NEVADA");
            StateList.Add("NEW HAMPSHIRE");
            StateList.Add("NEW JERSEY ");
            StateList.Add("NEW MEXICO");
            StateList.Add("NEW YORK");
            StateList.Add("NORTH CAROLINA");
            StateList.Add("NORTH DAKOTA");
            StateList.Add("OHIO");
            StateList.Add("OKLAHOMA");
            StateList.Add("OREGON");
            StateList.Add("PENNSYLVANIA");
            StateList.Add("RHODE ISLAND");
            StateList.Add("SOUTH CAROLINA");
            StateList.Add("SOUTH DAKOTA");
            StateList.Add("TENNESSEE");
            StateList.Add("TEXAS");
            StateList.Add("UTAH");
            StateList.Add("VERMONT");
            StateList.Add("VIRGINIA");
            StateList.Add("WASHINGTON");
            StateList.Add("WEST VIRGINIA");
            StateList.Add("WISCONSIN");
            StateList.Add("WYOMING");

            return StateList.AsEnumerable();

        }
    }
}