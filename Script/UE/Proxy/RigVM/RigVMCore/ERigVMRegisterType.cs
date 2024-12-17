using Script.CoreUObject;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.ERigVMRegisterType")]
	public enum ERigVMRegisterType : byte
	{
		Plain = 0,
		String = 1,
		Name = 2,
		Struct = 3,
		Invalid = 4,
	}
}