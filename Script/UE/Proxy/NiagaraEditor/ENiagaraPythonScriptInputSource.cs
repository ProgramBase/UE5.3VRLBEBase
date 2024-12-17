using Script.CoreUObject;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.ENiagaraPythonScriptInputSource")]
	public enum ENiagaraPythonScriptInputSource : long
	{
		Input = 0,
		Output = 1,
		Local = 2,
		InputOutput = 3,
		InitialValueInput = 4,
		None = 5,
		Num = 6,
	}
}