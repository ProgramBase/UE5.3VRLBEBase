using Script.CoreUObject;

namespace Script.HotPatcherEditor
{
	[PathName("/Script/HotPatcherEditor.EHotPatcherActionModes")]
	public enum EHotPatcherActionModes : long
	{
		ByPatch = 0,
		ByRelease = 1,
		ByShaderPatch = 2,
		ByGameFeature = 3,
		Count = 4,
	}
}