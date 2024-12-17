using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneEventSectionBase")]
	public partial class UMovieSceneEventSectionBase : UMovieSceneSection, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.MovieSceneEventSectionBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}