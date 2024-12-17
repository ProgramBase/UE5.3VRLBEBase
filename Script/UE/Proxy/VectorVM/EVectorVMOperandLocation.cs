using Script.CoreUObject;

namespace Script.VectorVM
{
	[PathName("/Script/VectorVM.EVectorVMOperandLocation")]
	public enum EVectorVMOperandLocation : long
	{
		Register = 0,
		Constant = 1,
		Num = 2,
	}
}