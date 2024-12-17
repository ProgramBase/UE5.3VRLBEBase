using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EEvaluatorDataSource")]
	public enum EEvaluatorDataSource : byte
	{
		EDS_SourcePose = 0,
		EDS_DestinationPose = 1,
	}
}