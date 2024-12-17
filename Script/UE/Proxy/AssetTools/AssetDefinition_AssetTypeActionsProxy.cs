using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.AssetTools
{
	[PathName("/Script/AssetTools.AssetDefinition_AssetTypeActionsProxy")]
	public partial class UAssetDefinition_AssetTypeActionsProxy : UAssetDefinitionDefault, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AssetTools.AssetDefinition_AssetTypeActionsProxy");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}