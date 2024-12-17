using Script.CoreUObject;
using Script.Library;

namespace Script.MovieSceneCapture
{
	[PathName("/Script/MovieSceneCapture.MovieSceneAudioCaptureProtocolBase")]
	public partial class UMovieSceneAudioCaptureProtocolBase : UMovieSceneCaptureProtocolBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneCapture.MovieSceneAudioCaptureProtocolBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}