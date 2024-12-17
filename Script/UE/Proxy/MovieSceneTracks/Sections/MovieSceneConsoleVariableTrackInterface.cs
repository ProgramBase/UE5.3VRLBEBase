using Script.CoreUObject;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneConsoleVariableTrackInterface")]
	public partial class UMovieSceneConsoleVariableTrackInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.MovieSceneConsoleVariableTrackInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/MovieSceneTracks.MovieSceneConsoleVariableTrackInterface")]
	public interface IMovieSceneConsoleVariableTrackInterface : IInterface
	{
	}
}