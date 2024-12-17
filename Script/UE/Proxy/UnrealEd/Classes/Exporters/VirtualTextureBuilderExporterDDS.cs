using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.VirtualTextureBuilderExporterDDS")]
	public partial class UVirtualTextureBuilderExporterDDS : UTextureExporterDDS, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.VirtualTextureBuilderExporterDDS");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}