using Script.CoreUObject;
using Script.Library;

namespace Script.ContentBrowser
{
	[PathName("/Script/ContentBrowser.TextFilterValueHandler")]
	public partial class UTextFilterValueHandler : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ContentBrowser.TextFilterValueHandler");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}