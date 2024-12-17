using Script.CoreUObject;
using Script.Library;

namespace Script.MovieSceneCapture
{
	[PathName("/Script/MovieSceneCapture.MovieSceneImageCaptureProtocolBase")]
	public partial class UMovieSceneImageCaptureProtocolBase : UMovieSceneCaptureProtocolBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneCapture.MovieSceneImageCaptureProtocolBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}