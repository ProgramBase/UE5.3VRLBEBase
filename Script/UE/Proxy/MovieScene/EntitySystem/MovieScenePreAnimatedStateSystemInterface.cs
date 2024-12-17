using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieScenePreAnimatedStateSystemInterface")]
	public partial class UMovieScenePreAnimatedStateSystemInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieScene.MovieScenePreAnimatedStateSystemInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/MovieScene.MovieScenePreAnimatedStateSystemInterface")]
	public interface IMovieScenePreAnimatedStateSystemInterface : IInterface
	{
	}
}