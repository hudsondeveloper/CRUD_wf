using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebForms_CRUD.Conexao;
using WebForms_CRUD.Models;

namespace WebForms_CRUD.Views.Cadastro
{
	public partial class Cadastro : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			
			if (Request.QueryString["valor"] != null)
			{
				if (Cadastrar.Text == "Editar")
				{
					using (ISession session = Connection.OpenSession())
					{
						using (ITransaction trans = session.BeginTransaction())
						{
							var aluno = session.Get<Aluno>(int.Parse(Request.QueryString["valor"]));
							aluno.Nome=nome.Text ;
							aluno.Sexo = Masculino.Checked?"M":"F";
							aluno.Curso= Estudo.Text;
							aluno.Email=Email.Text;
							session.Update(aluno);
							trans.Commit();
							session.Close();
						}
					}
				}
				else
				{
					Cadastrar.Text = "Editar";
					using (ISession session = Connection.OpenSession())
					{
							var aluno = session.Get<Aluno>(int.Parse(Request.QueryString["valor"]));
							nome.Text = aluno.Nome;
							Masculino.Checked = aluno.Sexo.Equals("M");
							Feminino.Checked = aluno.Sexo.Equals("F");
							Estudo.Text = aluno.Curso;
							Email.Text = aluno.Email;			
							session.Close();					
					}
				}
			}
		}

		protected void Cadastrar_Click(object sender, EventArgs e)
		{
			if (Request.QueryString["valor"] == null)
			{
				Aluno aluno = new Aluno();
				aluno.Nome = nome.Text;
				aluno.Sexo = Masculino.Checked ? "M" : "F";
				aluno.Curso = Estudo.Text;
				aluno.Email = Email.Text;
				using (ISession session = Connection.OpenSession())
				{
					using (ITransaction transaction = session.BeginTransaction())
					{
						int Gerador = 0;
						if (session.Query<Aluno>().ToList().Count() == 0)
							Gerador = 1;
						else
							Gerador = session.Query<Aluno>().ToList().OrderByDescending(x => x.Id).FirstOrDefault().Id + 1;

						aluno.Id = Gerador;

						session.Save(aluno);
						transaction.Commit();
						session.Close();
					}
				}
			}
			Response.Redirect("\\views/Listar/Listar.aspx");
		}

		protected void Button2_Click(object sender, EventArgs e)
		{
			Response.Redirect("\\views/index/index.aspx");
		}
	}
}