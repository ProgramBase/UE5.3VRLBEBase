using Script.CoreUObject;

namespace Script.Slate
{
	[PathName("/Script/Slate.EVirtualKeyboardDismissAction")]
	public enum EVirtualKeyboardDismissAction : byte
	{
		TextChangeOnDismiss = 0,
		TextCommitOnAccept = 1,
		TextCommitOnDismiss = 2,
	}
}