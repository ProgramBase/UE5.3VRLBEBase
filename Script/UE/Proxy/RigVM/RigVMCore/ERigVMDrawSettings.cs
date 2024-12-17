using Script.CoreUObject;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.ERigVMDrawSettings")]
	public enum ERigVMDrawSettings : byte
	{
		Points = 0,
		Lines = 1,
		LineStrip = 2,
		DynamicMesh = 3,
	}
}