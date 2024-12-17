using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENiagaraMeshFacingMode")]
	public enum ENiagaraMeshFacingMode : byte
	{
		Default = 0,
		Velocity = 1,
		CameraPosition = 2,
		CameraPlane = 3,
	}
}