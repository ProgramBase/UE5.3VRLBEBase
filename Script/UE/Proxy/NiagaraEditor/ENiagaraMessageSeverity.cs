using Script.CoreUObject;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.ENiagaraMessageSeverity")]
	public enum ENiagaraMessageSeverity : byte
	{
		CriticalError = 0,
		Error = 1,
		PerformanceWarning = 2,
		Warning = 3,
		Info = 4,
		CustomNote = 5,
	}
}