﻿using System.Web;
using System.Web.Mvc;

namespace U22497430_HW03
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}
