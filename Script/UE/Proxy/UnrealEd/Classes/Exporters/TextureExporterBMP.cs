using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.TextureExporterBMP")]
	public partial class UTextureExporterBMP : UTextureExporterGeneric, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.TextureExporterBMP");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}