using Script.CoreUObject;
using Script.Library;

namespace Script.AudioAnalyzer
{
	[PathName("/Script/AudioAnalyzer.AudioAnalyzerSettings")]
	public partial class UAudioAnalyzerSettings : UAudioAnalyzerAssetBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioAnalyzer.AudioAnalyzerSettings");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}