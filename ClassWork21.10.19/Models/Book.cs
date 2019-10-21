using ClassWork21_10_19.Models;
using System;
using System.Collections.Generic;

namespace NavigationLesson.Models
{

	public class Book : Entity 
	{		
		public string Title { get; set; }
		//public Guid AuthorId { get; set; }
		public Author Author { get; set; }

		public List<BooksStudents> BooksStudents { get; set; }
	}
}
