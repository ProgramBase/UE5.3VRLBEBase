using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.TextureExporterHDR")]
	public partial class UTextureExporterHDR : UTextureExporterGeneric, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.TextureExporterHDR");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}