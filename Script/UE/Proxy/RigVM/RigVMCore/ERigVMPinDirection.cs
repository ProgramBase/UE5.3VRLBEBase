using Script.CoreUObject;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.ERigVMPinDirection")]
	public enum ERigVMPinDirection : byte
	{
		Input = 0,
		Output = 1,
		IO = 2,
		Visible = 3,
		Hidden = 4,
		Invalid = 5,
	}
}