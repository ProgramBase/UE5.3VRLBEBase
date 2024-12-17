using Script.CoreUObject;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.ENiagaraLibrarySynchronizedDefaultMode")]
	public enum ENiagaraLibrarySynchronizedDefaultMode : long
	{
		Definition = 0,
		Value = 1,
		Binding = 2,
		Custom = 3,
		FailIfPreviouslyNotSet = 4,
	}
}