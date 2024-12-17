using Script.CoreUObject;
using Script.Library;

namespace Script.EditorWidgets
{
	[PathName("/Script/EditorWidgets.AssetFilterBarContext")]
	public partial class UAssetFilterBarContext : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EditorWidgets.AssetFilterBarContext");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}