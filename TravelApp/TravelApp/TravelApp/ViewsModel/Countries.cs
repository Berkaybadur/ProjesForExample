using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace TravelApp.ViewsModel
{
	public class Countries
	{
        public Countries()
        {
            Provinces = new HashSet<Provinces>();
        }

        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string CountryPopulation { get; set; }
        public string CountryDesc { get; set; }
        public string Image { get; set; }
        public ImageSource ImageSource { get; set; }

        public virtual ICollection<Provinces> Provinces { get; set; }
    }
}
