using Script.CoreUObject;

namespace Script.Slate
{
	[PathName("/Script/Slate.EMultiBlockType")]
	public enum EMultiBlockType : byte
	{
		None = 0,
		ButtonRow = 1,
		EditableText = 2,
		Heading = 3,
		MenuEntry = 4,
		Separator = 5,
		ToolBarButton = 6,
		ToolBarComboButton = 7,
		Widget = 8,
	}
}