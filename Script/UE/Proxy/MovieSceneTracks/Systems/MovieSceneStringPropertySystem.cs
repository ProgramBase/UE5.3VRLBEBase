using Script.CoreUObject;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneStringPropertySystem")]
	public partial class UMovieSceneStringPropertySystem : UMovieScenePropertySystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.MovieSceneStringPropertySystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}