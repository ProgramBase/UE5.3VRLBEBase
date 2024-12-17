using Script.CoreUObject;
using Script.Library;

namespace Script.ContentBrowser
{
	[PathName("/Script/ContentBrowser.ContentBrowserAssetViewContextMenuContext")]
	public partial class UContentBrowserAssetViewContextMenuContext : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ContentBrowser.ContentBrowserAssetViewContextMenuContext");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}