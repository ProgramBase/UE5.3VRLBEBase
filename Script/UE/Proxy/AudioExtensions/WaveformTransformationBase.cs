using Script.CoreUObject;
using Script.Library;

namespace Script.AudioExtensions
{
	[PathName("/Script/AudioExtensions.WaveformTransformationBase")]
	public partial class UWaveformTransformationBase : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioExtensions.WaveformTransformationBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}