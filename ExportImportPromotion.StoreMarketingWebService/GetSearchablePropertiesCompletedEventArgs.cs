using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
namespace ExportImportPromotion.StoreMarketingWebService
{
	[GeneratedCode("System.Web.Services", "4.0.30319.1"), DesignerCategory("code"), DebuggerStepThrough]
	public class GetSearchablePropertiesCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;
		public DataSet Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (DataSet)this.results[0];
			}
		}
		internal GetSearchablePropertiesCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}
