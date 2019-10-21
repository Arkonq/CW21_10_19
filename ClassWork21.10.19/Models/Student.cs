using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork21_10_19.Models
{
	public class Student : Entity
	{
		public string Fullname { get; set; }

		public List<BooksStudents> BooksStudents { get; set; }
	}
}
