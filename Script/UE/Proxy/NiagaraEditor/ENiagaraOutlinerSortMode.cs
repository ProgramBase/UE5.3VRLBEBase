using Script.CoreUObject;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.ENiagaraOutlinerSortMode")]
	public enum ENiagaraOutlinerSortMode : byte
	{
		Auto = 0,
		FilterMatches = 1,
		AverageTime = 2,
		MaxTime = 3,
	}
}