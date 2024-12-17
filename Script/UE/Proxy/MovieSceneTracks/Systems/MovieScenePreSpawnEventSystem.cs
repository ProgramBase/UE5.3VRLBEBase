using Script.CoreUObject;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieScenePreSpawnEventSystem")]
	public partial class UMovieScenePreSpawnEventSystem : UMovieSceneEventSystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.MovieScenePreSpawnEventSystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}