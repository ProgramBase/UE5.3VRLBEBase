using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneSequencePlayerObserver")]
	public partial class UMovieSceneSequencePlayerObserver : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieScene.MovieSceneSequencePlayerObserver");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/MovieScene.MovieSceneSequencePlayerObserver")]
	public interface IMovieSceneSequencePlayerObserver : IInterface
	{
	}
}