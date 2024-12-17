using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EImportanceLevel")]
	public enum EImportanceLevel : long
	{
		IL_Off = 0,
		IL_Lowest = 1,
		IL_Low = 2,
		IL_Normal = 3,
		IL_High = 4,
		IL_Highest = 5,
		TEMP_BROKEN2 = 6,
	}
}