using Script.CoreUObject;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.EMovieScenePlayerStatus")]
	public enum EMovieScenePlayerStatus : byte
	{
		Stopped = 0,
		Playing = 1,
		Scrubbing = 2,
		Jumping = 3,
		Stepping = 4,
		Paused = 5,
	}
}