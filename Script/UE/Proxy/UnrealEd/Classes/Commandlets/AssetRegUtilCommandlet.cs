using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.AssetRegUtilCommandlet")]
	public partial class UAssetRegUtilCommandlet : UCommandlet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.AssetRegUtilCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}