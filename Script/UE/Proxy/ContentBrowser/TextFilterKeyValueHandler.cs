using Script.CoreUObject;
using Script.Library;

namespace Script.ContentBrowser
{
	[PathName("/Script/ContentBrowser.TextFilterKeyValueHandler")]
	public partial class UTextFilterKeyValueHandler : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ContentBrowser.TextFilterKeyValueHandler");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}