using Script.CoreUObject;
using Script.Library;

namespace Script.EngineAssetDefinitions
{
	[PathName("/Script/EngineAssetDefinitions.AssetDefinition_Texture2DArray")]
	public partial class UAssetDefinition_Texture2DArray : UAssetDefinition_Texture, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EngineAssetDefinitions.AssetDefinition_Texture2DArray");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}