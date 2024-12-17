using Script.CoreUObject;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.ERigVMParameterType")]
	public enum ERigVMParameterType : byte
	{
		Input = 0,
		Output = 1,
		Invalid = 2,
	}
}