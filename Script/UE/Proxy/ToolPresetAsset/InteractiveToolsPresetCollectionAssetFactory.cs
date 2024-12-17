using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.ToolPresetAsset
{
	[PathName("/Script/ToolPresetAsset.InteractiveToolsPresetCollectionAssetFactory")]
	public partial class UInteractiveToolsPresetCollectionAssetFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ToolPresetAsset.InteractiveToolsPresetCollectionAssetFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}