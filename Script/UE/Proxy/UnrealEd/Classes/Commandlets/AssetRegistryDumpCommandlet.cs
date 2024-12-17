using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.AssetRegistryDumpCommandlet")]
	public partial class UAssetRegistryDumpCommandlet : UCommandlet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.AssetRegistryDumpCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}