using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENiagaraNumericOutputTypeSelectionMode")]
	public enum ENiagaraNumericOutputTypeSelectionMode : byte
	{
		None = 0,
		Largest = 1,
		Smallest = 2,
		Scalar = 3,
		Custom = 4,
	}
}