using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneEasingFunction")]
	public partial class UMovieSceneEasingFunction : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieScene.MovieSceneEasingFunction");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/MovieScene.MovieSceneEasingFunction")]
	public interface IMovieSceneEasingFunction : IInterface
	{
		 float OnEvaluate(float Interp);
	}
}