using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.FloatPerlinNoiseChannelEvaluatorSystem")]
	public partial class UFloatPerlinNoiseChannelEvaluatorSystem : UMovieSceneEntitySystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.FloatPerlinNoiseChannelEvaluatorSystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}