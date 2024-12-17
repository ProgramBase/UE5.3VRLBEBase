using Script.CoreUObject;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.ERigTransformStackEntryType")]
	public enum ERigTransformStackEntryType : byte
	{
		TransformPose = 0,
		ControlOffset = 1,
		ControlShape = 2,
		CurveValue = 3,
	}
}