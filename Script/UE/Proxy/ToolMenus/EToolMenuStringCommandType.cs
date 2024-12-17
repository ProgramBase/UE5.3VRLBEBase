using Script.CoreUObject;

namespace Script.ToolMenus
{
	[PathName("/Script/ToolMenus.EToolMenuStringCommandType")]
	public enum EToolMenuStringCommandType : byte
	{
		Command = 0,
		Python = 1,
		Custom = 2,
	}
}