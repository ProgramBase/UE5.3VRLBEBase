using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.TextBufferExporterTXT")]
	public partial class UTextBufferExporterTXT : UExporter, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.TextBufferExporterTXT");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}