using Script.CoreUObject;

namespace Script.HotPatcherEditor
{
	[PathName("/Script/HotPatcherEditor.EHotPatcherCookActionMode")]
	public enum EHotPatcherCookActionMode : long
	{
		ByOriginal = 0,
		ByPatch = 1,
	}
}