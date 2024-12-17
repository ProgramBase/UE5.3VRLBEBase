using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneDeferredComponentMovementSystem")]
	public partial class UMovieSceneDeferredComponentMovementSystem : UMovieSceneEntitySystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.MovieSceneDeferredComponentMovementSystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}