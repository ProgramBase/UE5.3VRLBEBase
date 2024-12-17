using Script.CoreUObject;
using Script.Library;

namespace Script.AudioAnalyzer
{
	[PathName("/Script/AudioAnalyzer.AudioAnalyzerNRTSettings")]
	public partial class UAudioAnalyzerNRTSettings : UAudioAnalyzerAssetBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioAnalyzer.AudioAnalyzerNRTSettings");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}