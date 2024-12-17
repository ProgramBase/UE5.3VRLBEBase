using Script.CoreUObject;

namespace Script.UVEditorTools
{
	[PathName("/Script/UVEditorTools.EChannelEditToolAction")]
	public enum EChannelEditToolAction : int
	{
		NoAction = 0,
		Add = 1,
		Copy = 2,
		Delete = 3,
	}
}