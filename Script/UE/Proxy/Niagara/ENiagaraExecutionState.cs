using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENiagaraExecutionState")]
	public enum ENiagaraExecutionState : uint
	{
		Active = 0,
		Inactive = 1,
		InactiveClear = 2,
		Complete = 3,
		Disabled = 4,
		Num = 5,
	}
}