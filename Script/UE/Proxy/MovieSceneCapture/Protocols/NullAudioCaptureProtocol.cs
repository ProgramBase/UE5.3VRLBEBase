using Script.CoreUObject;
using Script.Library;

namespace Script.MovieSceneCapture
{
	[PathName("/Script/MovieSceneCapture.NullAudioCaptureProtocol")]
	public partial class UNullAudioCaptureProtocol : UMovieSceneAudioCaptureProtocolBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneCapture.NullAudioCaptureProtocol");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}