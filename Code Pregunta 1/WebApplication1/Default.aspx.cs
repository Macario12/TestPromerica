﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
	public partial class _Default : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void btnSubmit_Click(object sender, EventArgs e)
		{
			// Aquí puedes añadir lógica adicional para manejar el login si es necesario
			Response.Write("<script>alert('Formulario enviado correctamente.');</script>");
		}
	}
}