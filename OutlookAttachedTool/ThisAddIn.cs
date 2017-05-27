using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Core;
using System.Diagnostics;

namespace OutlookAttachedTool
{
	public partial class ThisAddIn
	{

	}
	public partial class ThisAddIn
	{
		Outlook.Application m_Application;
		Outlook.Explorers m_Explorers;
		Outlook.Inspectors m_Inspectors;

		private void ThisAddIn_Startup(object sender, System.EventArgs e)
		{
			m_Application = this.Application;
			m_Explorers = m_Application.Explorers;
			m_Inspectors = m_Application.Inspectors;
			m_Inspectors.NewInspector +=
				new Outlook.InspectorsEvents_NewInspectorEventHandler(
					Inspectors_NewInspector);
		}

		private void Inspectors_NewInspector(Outlook.Inspector Inspector)
		{
			Console.WriteLine("");
		}

		protected override Microsoft.Office.Core.IRibbonExtensibility CreateRibbonExtensibilityObject()
		{
			return Globals.Factory.GetRibbonFactory().CreateRibbonManager(
				new Microsoft.Office.Tools.Ribbon.IRibbonExtension[] { 
					new NewMailAttachedTool(),
					new ReadMailAttachedTool()
				});
		}
		//protected override Microsoft.Office.Tools.Ribbon.IRibbonExtension[] CreateRibbonObjects()
		//{
		//	return new Microsoft.Office.Tools.Ribbon.IRibbonExtension[]
		//	{
		//		new Ribbon()
		//	};
		//}


		private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
		{
		}

		#region VSTO で生成されたコード

		/// <summary>
		/// デザイナーのサポートに必要なメソッドです。
		/// このメソッドの内容をコード エディターで変更しないでください。
		/// </summary>
		private void InternalStartup()
		{
			this.Startup += new System.EventHandler(ThisAddIn_Startup);
			this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
		}

		#endregion
	}
}
