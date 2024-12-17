using Script.CoreUObject;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.ERigVMTransformSpace")]
	public enum ERigVMTransformSpace : byte
	{
		LocalSpace = 0,
		GlobalSpace = 1,
		Max = 2,
	}
}