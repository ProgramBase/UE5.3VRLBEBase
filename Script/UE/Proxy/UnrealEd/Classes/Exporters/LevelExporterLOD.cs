using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.LevelExporterLOD")]
	public partial class ULevelExporterLOD : UExporter, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.LevelExporterLOD");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}