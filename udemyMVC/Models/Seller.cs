using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace udemyMVC.Models
{
	public class Seller
	{
		public int SellerId { get; set; }
		public string Name { get; set; }
		public string LastName { get; set; }
		[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
		public DateTime Birthday { get; set; }
		public string Street { get; set; }
		public string NoInt { get; set; }
		public string Urbanization { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string Country { get; set; }
		public int ZipCode { get; set; }
	}
}