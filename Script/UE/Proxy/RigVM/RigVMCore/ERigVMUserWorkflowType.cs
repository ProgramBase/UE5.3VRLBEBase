using Script.CoreUObject;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.ERigVMUserWorkflowType")]
	public enum ERigVMUserWorkflowType : byte
	{
		Invalid = 0,
		NodeContext = 1,
		PinContext = 2,
		OnPinDefaultChanged = 4,
		All = 7,
	}
}