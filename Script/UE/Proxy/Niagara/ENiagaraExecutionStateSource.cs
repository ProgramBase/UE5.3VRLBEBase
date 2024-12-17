using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENiagaraExecutionStateSource")]
	public enum ENiagaraExecutionStateSource : long
	{
		Scalability = 0,
		Internal = 1,
		Owner = 2,
		InternalCompletion = 3,
	}
}