using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EEvaluateCurveTableResult")]
	public enum EEvaluateCurveTableResult : byte
	{
		RowFound = 0,
		RowNotFound = 1,
	}
}