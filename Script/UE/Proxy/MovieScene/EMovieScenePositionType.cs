using Script.CoreUObject;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.EMovieScenePositionType")]
	public enum EMovieScenePositionType : byte
	{
		Frame = 0,
		Time = 1,
		MarkedFrame = 2,
	}
}