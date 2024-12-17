using Script.CoreUObject;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.ERigVMBreakpointAction")]
	public enum ERigVMBreakpointAction : long
	{
		None = 0,
		Resume = 1,
		StepOver = 2,
		StepInto = 3,
		StepOut = 4,
		Max = 5,
	}
}