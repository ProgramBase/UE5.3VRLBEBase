using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneRestorePreAnimatedStateSystem")]
	public partial class UMovieSceneRestorePreAnimatedStateSystem : UMovieSceneEntityInstantiatorSystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieScene.MovieSceneRestorePreAnimatedStateSystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}