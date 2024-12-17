using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneMotionVectorSimulationSystem")]
	public partial class UMovieSceneMotionVectorSimulationSystem : UMovieSceneEntitySystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.MovieSceneMotionVectorSimulationSystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}