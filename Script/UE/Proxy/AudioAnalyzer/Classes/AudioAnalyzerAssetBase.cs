using Script.CoreUObject;
using Script.Library;

namespace Script.AudioAnalyzer
{
	[PathName("/Script/AudioAnalyzer.AudioAnalyzerAssetBase")]
	public partial class UAudioAnalyzerAssetBase : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioAnalyzer.AudioAnalyzerAssetBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}