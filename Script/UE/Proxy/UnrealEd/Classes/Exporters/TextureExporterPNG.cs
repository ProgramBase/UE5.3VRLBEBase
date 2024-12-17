using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.TextureExporterPNG")]
	public partial class UTextureExporterPNG : UTextureExporterGeneric, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.TextureExporterPNG");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}