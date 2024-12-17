using Script.CoreUObject;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieScenePostSpawnEventSystem")]
	public partial class UMovieScenePostSpawnEventSystem : UMovieSceneEventSystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.MovieScenePostSpawnEventSystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}