using Script.CoreUObject;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.EShow3DTrajectory")]
	public enum EShow3DTrajectory : byte
	{
		EST_OnlyWhenSelected = 0,
		EST_Always = 1,
		EST_Never = 2,
	}
}