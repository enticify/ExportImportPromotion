using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;
namespace ExportImportPromotion.StoreMarketingWebService
{
#if MS
	[GeneratedCode("System.Xml", "4.0.30319.1"), Flags, XmlType(Namespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService")]
#else
	[GeneratedCode("System.Xml", "4.0.30319.1"), Flags, XmlType(Namespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService")]
#endif

	[Serializable]
	public enum RecurrenceDays
	{
		None = 1,
		Sunday = 2,
		Monday = 4,
		Tuesday = 8,
		Wednesday = 16,
		Thursday = 32,
		Friday = 64,
		Saturday = 128,
		Weekdays = 256,
		Weekend = 512,
		AllDays = 1024
	}
}
