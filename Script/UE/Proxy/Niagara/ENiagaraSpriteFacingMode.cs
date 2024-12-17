using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENiagaraSpriteFacingMode")]
	public enum ENiagaraSpriteFacingMode : byte
	{
		FaceCamera = 0,
		FaceCameraPlane = 1,
		CustomFacingVector = 2,
		FaceCameraPosition = 3,
		FaceCameraDistanceBlend = 4,
		Automatic = 5,
	}
}