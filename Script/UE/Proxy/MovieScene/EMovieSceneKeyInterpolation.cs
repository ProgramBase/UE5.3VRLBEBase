using Script.CoreUObject;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.EMovieSceneKeyInterpolation")]
	public enum EMovieSceneKeyInterpolation : byte
	{
		Auto = 0,
		User = 1,
		Break = 2,
		Linear = 3,
		Constant = 4,
		SmartAuto = 5,
	}
}