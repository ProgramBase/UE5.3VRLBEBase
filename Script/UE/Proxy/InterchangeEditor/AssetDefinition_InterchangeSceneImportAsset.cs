using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.InterchangeEditor
{
	[PathName("/Script/InterchangeEditor.AssetDefinition_InterchangeSceneImportAsset")]
	public partial class UAssetDefinition_InterchangeSceneImportAsset : UAssetDefinitionDefault, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeEditor.AssetDefinition_InterchangeSceneImportAsset");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}