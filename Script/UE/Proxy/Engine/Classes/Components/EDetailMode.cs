using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EDetailMode")]
	public enum EDetailMode : byte
	{
		DM_Low = 0,
		DM_Medium = 1,
		DM_High = 2,
		DM_Epic = 3,
	}
}