using Script.CoreUObject;
using Script.Library;

namespace Script.ContentBrowser
{
	[PathName("/Script/ContentBrowser.ContentBrowserAddNewContextMenuContext")]
	public partial class UContentBrowserAddNewContextMenuContext : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ContentBrowser.ContentBrowserAddNewContextMenuContext");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}