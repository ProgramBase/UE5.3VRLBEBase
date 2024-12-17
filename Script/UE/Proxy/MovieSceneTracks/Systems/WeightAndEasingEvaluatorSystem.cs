using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.WeightAndEasingEvaluatorSystem")]
	public partial class UWeightAndEasingEvaluatorSystem : UMovieSceneEntitySystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.WeightAndEasingEvaluatorSystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}