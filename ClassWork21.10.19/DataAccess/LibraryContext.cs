using ClassWork21_10_19.Models;
using Microsoft.EntityFrameworkCore;
using NavigationLesson.Models;

namespace ClassWork21_10_19.DataAccess
{
	public class LibraryContext : DbContext
	{
		public LibraryContext()
		{
			Database.EnsureCreated();
		}

		public DbSet<Book> Books { get; set; }
		public DbSet<Author> Authors { get; set; }
		public DbSet<Student> Students { get; set; }
		public DbSet<BooksStudents> BooksStudents { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=BorisHOME\\Boris;Database=LibraryDatabase_;Trusted_Connection=true;");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Book>().Property(x => x.Id).HasColumnName("_ID");
			modelBuilder.Entity<Book>().Property(x => x.CreationDate).HasColumnName("_creation_date");
			modelBuilder.Entity<Book>().Property(x => x.DeletedDate).HasColumnName("_deleted_date");

			modelBuilder.Entity<Author>().Property(x => x.Id).HasColumnName("_ID");
			modelBuilder.Entity<Author>().Property(x => x.CreationDate).HasColumnName("_creation_date");
			modelBuilder.Entity<Author>().Property(x => x.DeletedDate).HasColumnName("_deleted_date");

			modelBuilder.Entity<Student>().Property(x => x.Id).HasColumnName("_ID");
			modelBuilder.Entity<Student>().Property(x => x.CreationDate).HasColumnName("_creation_date");
			modelBuilder.Entity<Student>().Property(x => x.DeletedDate).HasColumnName("_deleted_date");

			modelBuilder.Entity<BooksStudents>().Property(x => x.Id).HasColumnName("_ID");
			modelBuilder.Entity<BooksStudents>().Property(x => x.CreationDate).HasColumnName("_dreation_date");
			modelBuilder.Entity<BooksStudents>().Property(x => x.DeletedDate).HasColumnName("_deleted_date");

			modelBuilder.Entity<Book>().ToTable("_books").Property(x => x.Title).HasColumnName("_name");
			modelBuilder.Entity<Author>().ToTable("_authors").Property(x => x.Fullname).HasColumnName("_fullName");
			modelBuilder.Entity<Student>().ToTable("_students").Property(x => x.Fullname).HasColumnName("_fullName");
			modelBuilder.Entity<BooksStudents>().ToTable("_books_students");
			modelBuilder.Entity<BooksStudents>().Property(x => x.BookId).HasColumnName("_book_ID");
			modelBuilder.Entity<BooksStudents>().Property(x => x.StudentId).HasColumnName("_student_ID");

			//modelBuilder.Entity<Book>().Property(x => x.Author).HasColumnName("_author_ID");

			modelBuilder.Entity<Author>()
				.HasMany(x => x.Books)
				.WithOne(x => x.Author);

			modelBuilder.Entity<BooksStudents>()
					 .HasKey(pt => new { pt.BookId, pt.StudentId });

			modelBuilder.Entity<BooksStudents>()
					.HasOne(bs => bs.Book)
					.WithMany(b => b.BooksStudents)
					.HasForeignKey(bs => bs.BookId);

			modelBuilder.Entity<BooksStudents>()
					.HasOne(bs => bs.Student)
					.WithMany(s => s.BooksStudents)
					.HasForeignKey(bs => bs.StudentId);
		}
		// книги авторы студенты
	}
}
