using Script.CoreUObject;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneColorPropertySystem")]
	public partial class UMovieSceneColorPropertySystem : UMovieScenePropertySystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.MovieSceneColorPropertySystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}