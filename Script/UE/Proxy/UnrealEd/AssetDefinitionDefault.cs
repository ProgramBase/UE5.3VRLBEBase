using Script.CoreUObject;
using Script.AssetDefinition;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.AssetDefinitionDefault")]
	public partial class UAssetDefinitionDefault : UAssetDefinition, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.AssetDefinitionDefault");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}