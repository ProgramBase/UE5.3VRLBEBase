using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.ToolPresetAsset
{
	[PathName("/Script/ToolPresetAsset.AssetDefinition_InteractiveToolsPresetCollectionAsset")]
	public partial class UAssetDefinition_InteractiveToolsPresetCollectionAsset : UAssetDefinitionDefault, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ToolPresetAsset.AssetDefinition_InteractiveToolsPresetCollectionAsset");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}