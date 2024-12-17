using Script.CoreUObject;

namespace Script.StatsViewer
{
	[PathName("/Script/StatsViewer.EPrimitiveObjectSets")]
	public enum EPrimitiveObjectSets : long
	{
		PrimitiveObjectSets_AllObjects = 0,
		PrimitiveObjectSets_CurrentLevel = 1,
		PrimitiveObjectSets_SelectedObjects = 2,
	}
}