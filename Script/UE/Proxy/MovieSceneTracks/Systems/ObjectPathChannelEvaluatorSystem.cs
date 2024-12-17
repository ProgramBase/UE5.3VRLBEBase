using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.ObjectPathChannelEvaluatorSystem")]
	public partial class UObjectPathChannelEvaluatorSystem : UMovieSceneEntitySystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.ObjectPathChannelEvaluatorSystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}