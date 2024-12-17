using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.VariantManagerContentEditor
{
	[PathName("/Script/VariantManagerContentEditor.AssetDefinition_LevelVariantSets")]
	public partial class UAssetDefinition_LevelVariantSets : UAssetDefinitionDefault, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/VariantManagerContentEditor.AssetDefinition_LevelVariantSets");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}