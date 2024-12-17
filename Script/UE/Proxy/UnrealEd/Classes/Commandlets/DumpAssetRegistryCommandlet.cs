using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.DumpAssetRegistryCommandlet")]
	public partial class UDumpAssetRegistryCommandlet : UCommandlet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.DumpAssetRegistryCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}