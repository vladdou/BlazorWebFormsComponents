﻿using Microsoft.AspNetCore.Components;

namespace BlazorWebFormsComponents
{
	public abstract class Page : ComponentBase
	{

		[CascadingParameter(Name = "Page")]
		protected BaseLayout BasePageLayout { get; set; }

		public string Title
		{
			get { return BasePageLayout.Title; }
			set { BasePageLayout.Title = value; }
		}


	}

}