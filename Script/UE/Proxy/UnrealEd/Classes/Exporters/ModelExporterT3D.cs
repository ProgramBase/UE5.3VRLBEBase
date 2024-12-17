using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ModelExporterT3D")]
	public partial class UModelExporterT3D : UExporter, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.ModelExporterT3D");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}