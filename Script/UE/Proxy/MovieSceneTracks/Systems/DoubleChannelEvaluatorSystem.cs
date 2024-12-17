using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.DoubleChannelEvaluatorSystem")]
	public partial class UDoubleChannelEvaluatorSystem : UMovieSceneEntitySystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.DoubleChannelEvaluatorSystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}