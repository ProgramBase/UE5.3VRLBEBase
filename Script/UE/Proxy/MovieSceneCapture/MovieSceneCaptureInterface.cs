using Script.CoreUObject;
using Script.Library;

namespace Script.MovieSceneCapture
{
	[PathName("/Script/MovieSceneCapture.MovieSceneCaptureInterface")]
	public partial class UMovieSceneCaptureInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneCapture.MovieSceneCaptureInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/MovieSceneCapture.MovieSceneCaptureInterface")]
	public interface IMovieSceneCaptureInterface : IInterface
	{
	}
}