using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENDISceneCapture2DSourceMode")]
	public enum ENDISceneCapture2DSourceMode : byte
	{
		UserParameterThenAttachParent = 0,
		UserParameterOnly = 1,
		AttachParentOnly = 2,
		Managed = 3,
	}
}