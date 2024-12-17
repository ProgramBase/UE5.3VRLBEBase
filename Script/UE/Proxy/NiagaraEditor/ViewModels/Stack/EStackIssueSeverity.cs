using Script.CoreUObject;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.EStackIssueSeverity")]
	public enum EStackIssueSeverity : long
	{
		Error = 0,
		Warning = 1,
		Info = 2,
		CustomNote = 3,
		None = 4,
	}
}