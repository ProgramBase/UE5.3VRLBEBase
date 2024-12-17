using Script.CoreUObject;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.ERigVMMemoryType")]
	public enum ERigVMMemoryType : byte
	{
		Work = 0,
		Literal = 1,
		External = 2,
		Debug = 3,
		Invalid = 4,
	}
}