using Script.CoreUObject;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieScenePostEvalEventSystem")]
	public partial class UMovieScenePostEvalEventSystem : UMovieSceneEventSystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.MovieScenePostEvalEventSystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}