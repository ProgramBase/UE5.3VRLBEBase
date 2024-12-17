using Script.CoreUObject;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneDoubleVectorPropertySystem")]
	public partial class UMovieSceneDoubleVectorPropertySystem : UMovieScenePropertySystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.MovieSceneDoubleVectorPropertySystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}