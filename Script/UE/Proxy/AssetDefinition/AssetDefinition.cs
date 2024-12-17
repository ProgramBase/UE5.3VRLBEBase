using Script.CoreUObject;
using Script.Library;

namespace Script.AssetDefinition
{
	[PathName("/Script/AssetDefinition.AssetDefinition")]
	public partial class UAssetDefinition : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AssetDefinition.AssetDefinition");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}