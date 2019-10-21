using ClassWork21_10_19.Models;
using NavigationLesson.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork21_10_19.Models
{
	public class BooksStudents : Entity
	{
		public Guid BookId { get; set; }
		public Book Book { get; set; }

		public Guid StudentId { get; set; }
		public Student Student { get; set; }
	}
}
