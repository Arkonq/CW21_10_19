using System;

namespace ClassWork21_10_19.Models
{
	public abstract class Entity
	{
		public Guid Id { get; set; } = Guid.NewGuid();
		public DateTime CreationDate { get; set; } = DateTime.Now;
		public DateTime? DeletedDate { get; set; }
	}
}
