using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneBaseValueEvaluatorSystem")]
	public partial class UMovieSceneBaseValueEvaluatorSystem : UMovieSceneEntitySystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.MovieSceneBaseValueEvaluatorSystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}