using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.GenerateGatherManifestCommandlet")]
	public partial class UGenerateGatherManifestCommandlet : UGatherTextCommandletBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.GenerateGatherManifestCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}