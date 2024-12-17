using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENiagaraBakerViewMode")]
	public enum ENiagaraBakerViewMode : int
	{
		Perspective = 0,
		OrthoFront = 1,
		OrthoBack = 2,
		OrthoLeft = 3,
		OrthoRight = 4,
		OrthoTop = 5,
		OrthoBottom = 6,
		Num = 7,
	}
}