using ClassWork21_10_19.DataAccess;
using ClassWork21_10_19.Models;
using NavigationLesson.Models;
using System;

namespace ClassWork21_10_19
{
	class Program 
	{
		static void Main()
		{
			using (var context = new LibraryContext())
			{
				//var result = context.Books.ToList();	// Не получает свойство AuthorId
				Author author = new Author
				{
					Fullname = "Jack London"
				};
				Book book = new Book
				{
					Title = "Martin Eden",
					Author = author
				};
				//Student student = new Student
				//{
				//	Fullname = "Tony Wade"
				//};


				context.Add(book);
				context.SaveChanges();
			}
		}
	}
}
