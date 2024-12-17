using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EEmitterNormalsMode")]
	public enum EEmitterNormalsMode : byte
	{
		ENM_CameraFacing = 0,
		ENM_Spherical = 1,
		ENM_Cylindrical = 2,
	}
}