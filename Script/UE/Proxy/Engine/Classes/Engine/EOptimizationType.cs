using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EOptimizationType")]
	public enum EOptimizationType : byte
	{
		OT_NumOfTriangles = 0,
		OT_MaxDeviation = 1,
	}
}