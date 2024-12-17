using Script.CoreUObject;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.ENiagaraClipboardFunctionInputValueMode")]
	public enum ENiagaraClipboardFunctionInputValueMode : int
	{
		Local = 0,
		Linked = 1,
		Data = 2,
		ObjectAsset = 3,
		Expression = 4,
		Dynamic = 5,
		ResetToDefault = 6,
	}
}