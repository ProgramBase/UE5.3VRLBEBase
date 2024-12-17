using Script.CoreUObject;
using Script.Library;

namespace Script.ContentBrowser
{
	[PathName("/Script/ContentBrowser.ContentBrowserToolbarMenuContext")]
	public partial class UContentBrowserToolbarMenuContext : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ContentBrowser.ContentBrowserToolbarMenuContext");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}