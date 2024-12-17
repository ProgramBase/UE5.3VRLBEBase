using Script.CoreUObject;
using Script.ContentBrowserData;
using Script.Library;

namespace Script.ContentBrowserFileDataSource
{
	[PathName("/Script/ContentBrowserFileDataSource.ContentBrowserFileDataSource")]
	public partial class UContentBrowserFileDataSource : UContentBrowserDataSource, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ContentBrowserFileDataSource.ContentBrowserFileDataSource");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}