using Script.CoreUObject;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.EFireEventsAtPosition")]
	public enum EFireEventsAtPosition : byte
	{
		AtStartOfEvaluation = 0,
		AtEndOfEvaluation = 1,
		AfterSpawn = 2,
	}
}