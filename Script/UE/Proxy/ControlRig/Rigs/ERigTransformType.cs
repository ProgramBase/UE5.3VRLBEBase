using Script.CoreUObject;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.ERigTransformType")]
	public enum ERigTransformType : byte
	{
		InitialLocal = 0,
		CurrentLocal = 1,
		InitialGlobal = 2,
		CurrentGlobal = 3,
		NumTransformTypes = 4,
	}
}