using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.SoundSurroundExporterWAV")]
	public partial class USoundSurroundExporterWAV : UExporter, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.SoundSurroundExporterWAV");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}