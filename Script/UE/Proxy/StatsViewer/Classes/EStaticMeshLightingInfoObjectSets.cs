using Script.CoreUObject;

namespace Script.StatsViewer
{
	[PathName("/Script/StatsViewer.EStaticMeshLightingInfoObjectSets")]
	public enum EStaticMeshLightingInfoObjectSets : long
	{
		StaticMeshLightingInfoObjectSets_CurrentLevel = 0,
		StaticMeshLightingInfoObjectSets_SelectedLevels = 1,
		StaticMeshLightingInfoObjectSets_AllLevels = 2,
	}
}