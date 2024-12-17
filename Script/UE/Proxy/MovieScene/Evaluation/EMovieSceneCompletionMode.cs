using Script.CoreUObject;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.EMovieSceneCompletionMode")]
	public enum EMovieSceneCompletionMode : byte
	{
		KeepState = 0,
		RestoreState = 1,
		ProjectDefault = 2,
	}
}