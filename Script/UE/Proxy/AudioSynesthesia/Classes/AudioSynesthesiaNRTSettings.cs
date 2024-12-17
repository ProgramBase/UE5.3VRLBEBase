using Script.CoreUObject;
using Script.AudioAnalyzer;
using Script.Library;

namespace Script.AudioSynesthesia
{
	[PathName("/Script/AudioSynesthesia.AudioSynesthesiaNRTSettings")]
	public partial class UAudioSynesthesiaNRTSettings : UAudioAnalyzerNRTSettings, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioSynesthesia.AudioSynesthesiaNRTSettings");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}