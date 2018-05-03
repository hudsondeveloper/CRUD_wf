using Microsoft.Reporting.WebForms;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebForms_CRUD.Conexao;
using WebForms_CRUD.Models;


namespace WebForms_CRUD.Views
{
	public partial class Index : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			Response.Redirect("\\views/Cadastro/Cadastro.aspx");
		}

		protected void Button1_Click1(object sender, EventArgs e)
		{
			Response.Redirect("\\views/Listar/Listar.aspx");
		}

		protected void Button2_Click(object sender, EventArgs e)
		{

			Page.Title = "Relatório";


			using (ISession session = Connection.OpenSession())
			{
				using (ITransaction transaction = session.BeginTransaction())
				{
					var ReportViewer1 = new ReportViewer();
					var aluno = session.Query<Aluno>().ToList();
					ReportDataSource rpda = new ReportDataSource();

					rpda.Name = "NorthwindProducts_Products";

					rpda.Value = aluno;

					ReportViewer1.LocalReport.DataSources.Clear();

					//Adiciona o objeto rpda ao controle ReportViewer

					ReportViewer1.LocalReport.DataSources.Add(rpda);

					ReportViewer1.LocalReport.ReportPath = "Reports/ReportProducts.rpt";
					ReportViewer1.LocalReport.Refresh();
					Response.Redirect("Reports/ReportProducts.rpt");
				
				}

			}


		}


	}


}