using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.SoundExporterWAV")]
	public partial class USoundExporterWAV : UExporter, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.SoundExporterWAV");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}