using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENiagaraCoordinateSpace")]
	public enum ENiagaraCoordinateSpace : long
	{
		Simulation = 0,
		World = 1,
		Local = 2,
	}
}