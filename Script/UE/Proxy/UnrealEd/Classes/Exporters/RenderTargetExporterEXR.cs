using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.RenderTargetExporterEXR")]
	public partial class URenderTargetExporterEXR : UExporter, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.RenderTargetExporterEXR");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}