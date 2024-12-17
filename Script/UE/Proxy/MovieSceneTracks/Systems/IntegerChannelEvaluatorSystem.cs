using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.IntegerChannelEvaluatorSystem")]
	public partial class UIntegerChannelEvaluatorSystem : UMovieSceneEntitySystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.IntegerChannelEvaluatorSystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}