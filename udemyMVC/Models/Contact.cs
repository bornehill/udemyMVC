using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace udemyMVC.Models
{
	public class Contact
	{
		public int ContactId { get; set; }
		public string Name { get; set; }
		public string LastName { get; set; }
		public string Street { get; set; }
		public string NoInt { get; set; }
		public string Urbanization { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string Country { get; set; }
		public int ZipCode { get; set; }
	}
}