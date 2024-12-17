using Script.CoreUObject;

namespace Script.ToolMenus
{
	[PathName("/Script/ToolMenus.EToolMenuInsertType")]
	public enum EToolMenuInsertType : byte
	{
		Default = 0,
		Before = 1,
		After = 2,
		First = 3,
	}
}