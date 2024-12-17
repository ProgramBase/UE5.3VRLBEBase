using Script.CoreUObject;

namespace Script.UMGEditor
{
	[PathName("/Script/UMGEditor.EDisplayOnCompile")]
	public enum EDisplayOnCompile : byte
	{
		DoC_ErrorsOrWarnings = 0,
		DoC_ErrorsOnly = 1,
		DoC_WarningsOnly = 2,
		DoC_Never = 3,
	}
}