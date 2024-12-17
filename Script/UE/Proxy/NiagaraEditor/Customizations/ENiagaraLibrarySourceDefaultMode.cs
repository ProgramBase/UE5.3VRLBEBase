using Script.CoreUObject;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.ENiagaraLibrarySourceDefaultMode")]
	public enum ENiagaraLibrarySourceDefaultMode : long
	{
		Value = 0,
		Binding = 1,
		FailIfPreviouslyNotSet = 2,
	}
}