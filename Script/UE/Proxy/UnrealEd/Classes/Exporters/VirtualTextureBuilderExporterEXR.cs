using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.VirtualTextureBuilderExporterEXR")]
	public partial class UVirtualTextureBuilderExporterEXR : UTextureExporterEXR, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.VirtualTextureBuilderExporterEXR");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}