using Script.CoreUObject;

namespace Script.LandscapeEditor
{
	[PathName("/Script/LandscapeEditor.ELandscapeMirrorOperation")]
	public enum ELandscapeMirrorOperation : byte
	{
		MinusXToPlusX = 0,
		PlusXToMinusX = 1,
		MinusYToPlusY = 2,
		PlusYToMinusY = 3,
		RotateMinusXToPlusX = 4,
		RotatePlusXToMinusX = 5,
		RotateMinusYToPlusY = 6,
		RotatePlusYToMinusY = 7,
	}
}