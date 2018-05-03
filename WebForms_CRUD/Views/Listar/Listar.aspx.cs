using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebForms_CRUD.Conexao;
using WebForms_CRUD.Models;

namespace WebForms_CRUD.Views.Listar
{
	public partial class Listar : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				using (ISession session = Connection.OpenSession())
				{
					List<Aluno> alunos = session.Query<Aluno>().ToList();
					int co = 0;
					CheckBoxList1.DataSource = alunos;
					GridView1.DataSource = alunos;
					//GridView1.DataKeyNames = alunos.Select(x=>x.Id.ToString()).ToArray();
					GridView1.DataBind();
					session.Close();
				}
			}


		}
		protected void Button2_Click(object sender, EventArgs e)
		{
			Response.Redirect("\\views/index/index.aspx");
		}


		protected void grdDados_RowCommand(object sender, GridViewCommandEventArgs e)
		{
			if (e.CommandName.Equals("Editar"))
			{
				string id = e.CommandArgument.ToString();
				if (!String.IsNullOrEmpty(id))
					Response.Redirect("\\views/Cadastro/Cadastro.aspx?valor=" + id);
			}
			else if (e.CommandName.Equals("Excluir"))
			{
				string id = e.CommandArgument.ToString();
				if (!String.IsNullOrEmpty(id))
				{
					using (ISession session = Connection.OpenSession())
					{
						using (ITransaction transaction = session.BeginTransaction())
						{
							var aluno = session.Get<Aluno>(int.Parse(id));
							session.Delete(aluno);
							transaction.Commit();
							session.Close();
						}
						Response.Redirect("\\views/Listar/Listar.aspx");
					}
				}
			}
		}
	}
}