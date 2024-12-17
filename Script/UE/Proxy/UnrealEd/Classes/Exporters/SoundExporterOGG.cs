using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.SoundExporterOGG")]
	public partial class USoundExporterOGG : UExporter, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.SoundExporterOGG");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}