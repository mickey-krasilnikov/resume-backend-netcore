using System.ComponentModel.DataAnnotations;

namespace ResumeApp.DataAccess.Sql.Entities
{
	public abstract class SqlEntityBase : IEntity
	{
		public DateTime CreatedAt { get; set; }

		public DateTime UpdatedAt { get; set; }
	}
}
