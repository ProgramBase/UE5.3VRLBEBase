using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENiagaraConditionalOperator")]
	public enum ENiagaraConditionalOperator : long
	{
		Equals = 0,
		NotEqual = 1,
		LessThan = 2,
		LessThanOrEqual = 3,
		GreaterThan = 4,
		GreaterThanOrEqual = 5,
		Max = 6,
	}
}