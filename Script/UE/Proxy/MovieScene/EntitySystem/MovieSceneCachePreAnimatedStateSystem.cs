using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneCachePreAnimatedStateSystem")]
	public partial class UMovieSceneCachePreAnimatedStateSystem : UMovieSceneEntityInstantiatorSystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieScene.MovieSceneCachePreAnimatedStateSystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}