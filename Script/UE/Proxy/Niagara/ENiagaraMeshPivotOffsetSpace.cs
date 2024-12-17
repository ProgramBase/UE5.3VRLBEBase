using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENiagaraMeshPivotOffsetSpace")]
	public enum ENiagaraMeshPivotOffsetSpace : byte
	{
		Mesh = 0,
		Simulation = 1,
		World = 2,
		Local = 3,
	}
}