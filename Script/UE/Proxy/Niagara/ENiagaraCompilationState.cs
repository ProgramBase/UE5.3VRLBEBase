using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENiagaraCompilationState")]
	public enum ENiagaraCompilationState : long
	{
		CheckDDC = 0,
		Precompile = 1,
		StartCompileJob = 2,
		AwaitResult = 3,
		OptimizeByteCode = 4,
		ProcessResult = 5,
		PutToDDC = 6,
		Finished = 7,
		Aborted = 8,
	}
}