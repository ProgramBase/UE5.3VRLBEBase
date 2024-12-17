using Script.CoreUObject;

namespace Script.Slate
{
	[PathName("/Script/Slate.EMultiBoxType")]
	public enum EMultiBoxType : byte
	{
		MenuBar = 0,
		ToolBar = 1,
		VerticalToolBar = 2,
		SlimHorizontalToolBar = 3,
		UniformToolBar = 4,
		Menu = 5,
		ButtonRow = 6,
		SlimHorizontalUniformToolBar = 7,
	}
}