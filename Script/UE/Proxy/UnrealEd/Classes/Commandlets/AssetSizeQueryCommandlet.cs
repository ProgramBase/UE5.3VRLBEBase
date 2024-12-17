using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.AssetSizeQueryCommandlet")]
	public partial class UAssetSizeQueryCommandlet : UCommandlet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.AssetSizeQueryCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}