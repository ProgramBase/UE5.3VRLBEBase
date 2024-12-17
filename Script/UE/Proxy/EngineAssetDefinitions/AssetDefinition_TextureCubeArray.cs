using Script.CoreUObject;
using Script.Library;

namespace Script.EngineAssetDefinitions
{
	[PathName("/Script/EngineAssetDefinitions.AssetDefinition_TextureCubeArray")]
	public partial class UAssetDefinition_TextureCubeArray : UAssetDefinition_Texture, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EngineAssetDefinitions.AssetDefinition_TextureCubeArray");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}