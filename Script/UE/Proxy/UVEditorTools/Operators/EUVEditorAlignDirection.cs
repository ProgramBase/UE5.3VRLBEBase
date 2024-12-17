using Script.CoreUObject;

namespace Script.UVEditorTools
{
	[PathName("/Script/UVEditorTools.EUVEditorAlignDirection")]
	public enum EUVEditorAlignDirection : int
	{
		None = 0,
		Top = 1,
		Bottom = 2,
		Left = 3,
		Right = 4,
		CenterVertically = 5,
		CenterHorizontally = 6,
	}
}