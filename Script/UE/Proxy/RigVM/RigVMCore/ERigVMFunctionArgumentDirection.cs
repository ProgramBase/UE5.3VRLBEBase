using Script.CoreUObject;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.ERigVMFunctionArgumentDirection")]
	public enum ERigVMFunctionArgumentDirection : long
	{
		Input = 0,
		Output = 1,
		Invalid = 2,
	}
}