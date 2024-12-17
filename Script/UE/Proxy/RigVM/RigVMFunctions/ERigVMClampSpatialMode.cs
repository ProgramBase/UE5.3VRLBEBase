using Script.CoreUObject;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.ERigVMClampSpatialMode")]
	public enum ERigVMClampSpatialMode : byte
	{
		Plane = 0,
		Cylinder = 1,
		Sphere = 2,
	}
}