using Script.CoreUObject;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.EConstraintInterpType")]
	public enum EConstraintInterpType : byte
	{
		Average = 0,
		Shortest = 1,
		Max = 2,
	}
}