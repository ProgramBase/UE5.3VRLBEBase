using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneAudioSystem")]
	public partial class UMovieSceneAudioSystem : UMovieSceneEntitySystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.MovieSceneAudioSystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}