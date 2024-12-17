using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.RenderTargetCubeExporterHDR")]
	public partial class URenderTargetCubeExporterHDR : UTextureCubeExporterHDR, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.RenderTargetCubeExporterHDR");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}