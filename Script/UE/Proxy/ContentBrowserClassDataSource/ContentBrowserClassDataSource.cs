using Script.CoreUObject;
using Script.ContentBrowserData;
using Script.Library;

namespace Script.ContentBrowserClassDataSource
{
	[PathName("/Script/ContentBrowserClassDataSource.ContentBrowserClassDataSource")]
	public partial class UContentBrowserClassDataSource : UContentBrowserDataSource, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ContentBrowserClassDataSource.ContentBrowserClassDataSource");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}