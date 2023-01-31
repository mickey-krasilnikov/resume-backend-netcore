﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResumeApp.DataAccess.Sql.Entities
{
	public class ExperienceSqlEntity
	{
		public ExperienceSqlEntity()
		{
			Skills = new HashSet<SkillSqlEntity>();
		}

		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public Guid Id { get; set; }

		[Required]
		public string Title { get; set; }

		[Required]
		public string Company { get; set; }

		public string Location { get; set; }

		public string[] TaskPerformed { get; set; }

		[Required]
		public DateOnly StartDate { get; set; }

		public DateOnly? EndDate { get; set; }


		public virtual ICollection<SkillSqlEntity> Skills { get; set; }
	}
}
