using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneSpawnablesSystem")]
	public partial class UMovieSceneSpawnablesSystem : UMovieSceneEntitySystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieScene.MovieSceneSpawnablesSystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}