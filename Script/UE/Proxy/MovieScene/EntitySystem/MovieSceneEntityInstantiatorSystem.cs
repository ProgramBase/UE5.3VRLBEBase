using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneEntityInstantiatorSystem")]
	public partial class UMovieSceneEntityInstantiatorSystem : UMovieSceneEntitySystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieScene.MovieSceneEntityInstantiatorSystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}