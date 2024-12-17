using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneRootInstantiatorSystem")]
	public partial class UMovieSceneRootInstantiatorSystem : UMovieSceneEntityInstantiatorSystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieScene.MovieSceneRootInstantiatorSystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}