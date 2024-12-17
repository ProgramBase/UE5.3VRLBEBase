using Script.CoreUObject;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.EMovieSceneSequenceFlags")]
	public enum EMovieSceneSequenceFlags : byte
	{
		None = 0,
		Volatile = 1,
		BlockingEvaluation = 2,
		DynamicWeighting = 4,
		InheritedFlags = 1,
	}
}