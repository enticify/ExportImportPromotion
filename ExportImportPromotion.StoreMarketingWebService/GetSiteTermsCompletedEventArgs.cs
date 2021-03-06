using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
namespace ExportImportPromotion.StoreMarketingWebService
{
	[GeneratedCode("System.Web.Services", "4.0.30319.1"), DesignerCategory("code"), DebuggerStepThrough]
	public class GetSiteTermsCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;
		public XmlElement Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (XmlElement)this.results[0];
			}
		}
		internal GetSiteTermsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}
