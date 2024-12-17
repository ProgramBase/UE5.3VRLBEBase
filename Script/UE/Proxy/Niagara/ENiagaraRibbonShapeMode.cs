using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENiagaraRibbonShapeMode")]
	public enum ENiagaraRibbonShapeMode : byte
	{
		Plane = 0,
		MultiPlane = 1,
		Tube = 2,
		Custom = 3,
	}
}