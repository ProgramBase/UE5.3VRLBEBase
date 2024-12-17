using Script.CoreUObject;
using Script.AudioAnalyzer;
using Script.Library;

namespace Script.AudioSynesthesia
{
	[PathName("/Script/AudioSynesthesia.AudioSynesthesiaNRT")]
	public partial class UAudioSynesthesiaNRT : UAudioAnalyzerNRT, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioSynesthesia.AudioSynesthesiaNRT");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}