using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.RenderTargetExporterPNG")]
	public partial class URenderTargetExporterPNG : UExporter, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.RenderTargetExporterPNG");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}