using Script.CoreUObject;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.ERigVMCopyType")]
	public enum ERigVMCopyType : long
	{
		Default = 0,
		FloatToDouble = 1,
		DoubleToFloat = 2,
	}
}