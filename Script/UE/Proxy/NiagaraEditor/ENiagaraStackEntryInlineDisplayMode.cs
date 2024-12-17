using Script.CoreUObject;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.ENiagaraStackEntryInlineDisplayMode")]
	public enum ENiagaraStackEntryInlineDisplayMode : int
	{
		Expression = 0,
		GraphHorizontal = 1,
		GraphVertical = 2,
		GraphHybrid = 3,
		None = 4,
	}
}