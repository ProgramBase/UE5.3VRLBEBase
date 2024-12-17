using Script.CoreUObject;
using Script.ContentBrowserData;
using Script.Library;

namespace Script.UnrealCSharpEditor
{
	[PathName("/Script/UnrealCSharpEditor.DynamicDataSource")]
	public partial class UDynamicDataSource : UContentBrowserDataSource, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealCSharpEditor.DynamicDataSource");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}