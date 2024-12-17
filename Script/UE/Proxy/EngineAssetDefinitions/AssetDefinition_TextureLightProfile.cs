using Script.CoreUObject;
using Script.Library;

namespace Script.EngineAssetDefinitions
{
	[PathName("/Script/EngineAssetDefinitions.AssetDefinition_TextureLightProfile")]
	public partial class UAssetDefinition_TextureLightProfile : UAssetDefinition_Texture, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EngineAssetDefinitions.AssetDefinition_TextureLightProfile");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}