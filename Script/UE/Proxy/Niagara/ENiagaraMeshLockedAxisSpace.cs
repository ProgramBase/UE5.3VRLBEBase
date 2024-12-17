using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENiagaraMeshLockedAxisSpace")]
	public enum ENiagaraMeshLockedAxisSpace : byte
	{
		Simulation = 0,
		World = 1,
		Local = 2,
	}
}