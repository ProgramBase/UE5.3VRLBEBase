using Script.CoreUObject;
using Script.AudioAnalyzer;
using Script.Library;

namespace Script.AudioSynesthesia
{
	[PathName("/Script/AudioSynesthesia.AudioSynesthesiaSettings")]
	public partial class UAudioSynesthesiaSettings : UAudioAnalyzerSettings, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioSynesthesia.AudioSynesthesiaSettings");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}