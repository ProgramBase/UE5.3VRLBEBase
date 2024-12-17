using Script.CoreUObject;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneDoublePropertySystem")]
	public partial class UMovieSceneDoublePropertySystem : UMovieScenePropertySystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.MovieSceneDoublePropertySystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}