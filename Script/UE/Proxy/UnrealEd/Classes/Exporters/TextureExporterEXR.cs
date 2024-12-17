using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.TextureExporterEXR")]
	public partial class UTextureExporterEXR : UTextureExporterGeneric, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.TextureExporterEXR");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}