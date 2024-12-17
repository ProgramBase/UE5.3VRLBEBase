using Script.CoreUObject;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.ERigUnitDebugTransformMode")]
	public enum ERigUnitDebugTransformMode : byte
	{
		Point = 0,
		Axes = 1,
		Box = 2,
		Max = 3,
	}
}