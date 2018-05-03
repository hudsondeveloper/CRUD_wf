using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebForms_CRUD.Models;

namespace WebForms_CRUD.Maping
{
	public class AlunoMap:ClassMap<Aluno>
	{
		public AlunoMap()
		{
			Table("Alunos");
			Id(x => x.Id).GeneratedBy.Increment().Nullable();
			Map(x => x.Nome);
			Map(x => x.Email);
			Map(x => x.Sexo);
			Map(x => x.Curso);
		}
	}
}