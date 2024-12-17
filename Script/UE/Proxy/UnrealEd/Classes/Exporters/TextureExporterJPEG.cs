using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.TextureExporterJPEG")]
	public partial class UTextureExporterJPEG : UExporter, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.TextureExporterJPEG");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}