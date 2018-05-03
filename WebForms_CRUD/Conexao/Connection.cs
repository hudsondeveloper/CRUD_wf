using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
namespace WebForms_CRUD.Conexao
{
	public class Connection
	{
		public static ISession OpenSession()
		{
			ISessionFactory sessionFactory = Fluently.Configure()
				.Database(MsSqlConfiguration.MsSql2012
				  .ConnectionString(@"Data Source=.\SQLEXPRESS;Initial Catalog=Cadastro;Persist Security Info=True;User ID=sa;Password=starwark11")
							  .ShowSql()
				)
			   .Mappings(m =>
						  m.FluentMappings
							  .AddFromAssemblyOf<Models.Aluno>())
				.ExposeConfiguration(cfg => new SchemaExport(cfg)
												.Create(true, false))
				.BuildSessionFactory();
			return sessionFactory.OpenSession();
		}
	}
}
