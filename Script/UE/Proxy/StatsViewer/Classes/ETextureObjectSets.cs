using Script.CoreUObject;

namespace Script.StatsViewer
{
	[PathName("/Script/StatsViewer.ETextureObjectSets")]
	public enum ETextureObjectSets : long
	{
		TextureObjectSet_CurrentStreamingLevel = 0,
		TextureObjectSet_AllStreamingLevels = 1,
		TextureObjectSet_SelectedActors = 2,
		TextureObjectSet_SelectedMaterials = 3,
	}
}