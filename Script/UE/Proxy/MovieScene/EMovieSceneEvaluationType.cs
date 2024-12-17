using Script.CoreUObject;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.EMovieSceneEvaluationType")]
	public enum EMovieSceneEvaluationType : byte
	{
		FrameLocked = 0,
		WithSubFrames = 1,
	}
}