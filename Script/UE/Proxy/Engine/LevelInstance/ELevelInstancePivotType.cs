using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ELevelInstancePivotType")]
	public enum ELevelInstancePivotType : byte
	{
		CenterMinZ = 0,
		Center = 1,
		Actor = 2,
		WorldOrigin = 3,
	}
}