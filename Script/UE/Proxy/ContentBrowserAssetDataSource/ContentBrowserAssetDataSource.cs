using Script.CoreUObject;
using Script.ContentBrowserData;
using Script.Library;

namespace Script.ContentBrowserAssetDataSource
{
	[PathName("/Script/ContentBrowserAssetDataSource.ContentBrowserAssetDataSource")]
	public partial class UContentBrowserAssetDataSource : UContentBrowserDataSource, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ContentBrowserAssetDataSource.ContentBrowserAssetDataSource");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}