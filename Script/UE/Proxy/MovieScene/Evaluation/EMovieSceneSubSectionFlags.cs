using Script.CoreUObject;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.EMovieSceneSubSectionFlags")]
	public enum EMovieSceneSubSectionFlags : int
	{
		None = 0,
		OverrideKeepState = 1,
		OverrideRestoreState = 2,
		IgnoreHierarchicalBias = 4,
		BlendHierarchicalBias = 8,
		AnyRestoreStateOverride = 3,
	}
}