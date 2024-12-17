using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EMeshCameraFacingUpAxis")]
	public enum EMeshCameraFacingUpAxis : long
	{
		CameraFacing_NoneUP = 0,
		CameraFacing_ZUp = 1,
		CameraFacing_NegativeZUp = 2,
		CameraFacing_YUp = 3,
		CameraFacing_NegativeYUp = 4,
	}
}