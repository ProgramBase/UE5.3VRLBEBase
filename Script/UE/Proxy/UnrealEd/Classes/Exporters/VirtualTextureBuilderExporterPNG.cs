using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.VirtualTextureBuilderExporterPNG")]
	public partial class UVirtualTextureBuilderExporterPNG : UTextureExporterPNG, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.VirtualTextureBuilderExporterPNG");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}