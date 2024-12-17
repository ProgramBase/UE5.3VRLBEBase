using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ENodeTitleType")]
	public enum ENodeTitleType : long
	{
		FullTitle = 0,
		ListView = 1,
		EditableTitle = 2,
		MenuTitle = 3,
		MAX_TitleTypes = 4,
	}
}