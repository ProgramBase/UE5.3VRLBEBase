using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.PolysExporterT3D")]
	public partial class UPolysExporterT3D : UExporter, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.PolysExporterT3D");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}