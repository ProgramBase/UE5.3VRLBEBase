using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ENetDormancy")]
	public enum ENetDormancy : byte
	{
		DORM_Never = 0,
		DORM_Awake = 1,
		DORM_DormantAll = 2,
		DORM_DormantPartial = 3,
		DORM_Initial = 4,
	}
}