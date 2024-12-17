using Script.CoreUObject;

namespace Script.Chaos
{
	[PathName("/Script/Chaos.EChaosSolverTickMode")]
	public enum EChaosSolverTickMode : byte
	{
		Fixed = 0,
		Variable = 1,
		VariableCapped = 2,
		VariableCappedWithTarget = 3,
	}
}