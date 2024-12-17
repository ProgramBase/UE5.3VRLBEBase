using Script.CoreUObject;
using Script.Library;

namespace Script.EngineAssetDefinitions
{
	[PathName("/Script/EngineAssetDefinitions.AssetDefinition_Blueprint")]
	public partial class UAssetDefinition_Blueprint : UAssetDefinition_ClassTypeBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EngineAssetDefinitions.AssetDefinition_Blueprint");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}