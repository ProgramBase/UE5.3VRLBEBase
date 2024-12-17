using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.DoublePerlinNoiseChannelEvaluatorSystem")]
	public partial class UDoublePerlinNoiseChannelEvaluatorSystem : UMovieSceneEntitySystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.DoublePerlinNoiseChannelEvaluatorSystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}