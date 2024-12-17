using Script.CoreUObject;
using Script.Library;

namespace Script.ContentBrowser
{
	[PathName("/Script/ContentBrowser.ContentBrowserFrontEndFilterExtension")]
	public partial class UContentBrowserFrontEndFilterExtension : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ContentBrowser.ContentBrowserFrontEndFilterExtension");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}