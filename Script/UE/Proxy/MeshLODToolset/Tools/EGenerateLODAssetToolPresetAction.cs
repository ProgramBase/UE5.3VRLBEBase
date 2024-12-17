using Script.CoreUObject;

namespace Script.MeshLODToolset
{
	[PathName("/Script/MeshLODToolset.EGenerateLODAssetToolPresetAction")]
	public enum EGenerateLODAssetToolPresetAction : long
	{
		ReadFromPreset = 0,
		WriteToPreset = 1,
	}
}