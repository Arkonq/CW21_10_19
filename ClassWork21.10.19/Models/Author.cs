using NavigationLesson.Models;
using System.Collections.Generic;

namespace ClassWork21_10_19.Models
{
	public class Author : Entity
	{
		public string Fullname { get; set; }
		public ICollection<Book> Books { get; set; }
	}
}
