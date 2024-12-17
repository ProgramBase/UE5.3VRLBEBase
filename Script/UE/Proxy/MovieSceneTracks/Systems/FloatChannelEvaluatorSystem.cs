using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.FloatChannelEvaluatorSystem")]
	public partial class UFloatChannelEvaluatorSystem : UMovieSceneEntitySystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.FloatChannelEvaluatorSystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}