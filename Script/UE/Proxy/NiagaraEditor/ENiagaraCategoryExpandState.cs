using Script.CoreUObject;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.ENiagaraCategoryExpandState")]
	public enum ENiagaraCategoryExpandState : byte
	{
		Default = 0,
		DefaultExpandModified = 1,
		CollapseAll = 2,
		ExpandAll = 3,
	}
}