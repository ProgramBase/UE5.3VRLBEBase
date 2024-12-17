using Script.CoreUObject;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.ERigVMSimPointIntegrateType")]
	public enum ERigVMSimPointIntegrateType : byte
	{
		Verlet = 0,
		SemiExplicitEuler = 1,
	}
}