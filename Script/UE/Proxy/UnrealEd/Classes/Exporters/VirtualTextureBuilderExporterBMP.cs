using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.VirtualTextureBuilderExporterBMP")]
	public partial class UVirtualTextureBuilderExporterBMP : UTextureExporterBMP, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.VirtualTextureBuilderExporterBMP");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}