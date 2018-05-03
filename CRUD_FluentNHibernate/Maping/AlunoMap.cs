using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentNHibernate.Mapping;

namespace WebForms_CRUD.Maping
{

	class AlunoMap : ClassMap<Models.Aluno>

	{

		public AlunoMap()

		{

			Id(x => x.Id).GeneratedBy.Increment().Not.Nullable();

			Map(x => x.Nome);

			Map(x => x.Email);

			Map(x => x.Curso);

			Map(x => x.Sexo);

			Table("Alunos");

		}

	}

}