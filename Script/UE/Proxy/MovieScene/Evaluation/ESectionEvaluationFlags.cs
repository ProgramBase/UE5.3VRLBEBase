using Script.CoreUObject;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.ESectionEvaluationFlags")]
	public enum ESectionEvaluationFlags : byte
	{
		None = 0,
		PreRoll = 1,
		PostRoll = 2,
		ForceKeepState = 4,
		ForceRestoreState = 8,
	}
}