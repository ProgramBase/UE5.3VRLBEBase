using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneHierarchicalBiasSystem")]
	public partial class UMovieSceneHierarchicalBiasSystem : UMovieSceneEntityInstantiatorSystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.MovieSceneHierarchicalBiasSystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}