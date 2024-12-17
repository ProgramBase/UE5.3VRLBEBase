using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.GenerateAssetManifestCommandlet")]
	public partial class UGenerateAssetManifestCommandlet : UCommandlet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.GenerateAssetManifestCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}