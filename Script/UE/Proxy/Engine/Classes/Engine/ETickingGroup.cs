using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ETickingGroup")]
	public enum ETickingGroup : byte
	{
		TG_PrePhysics = 0,
		TG_StartPhysics = 1,
		TG_DuringPhysics = 2,
		TG_EndPhysics = 3,
		TG_PostPhysics = 4,
		TG_PostUpdateWork = 5,
		TG_LastDemotable = 6,
		TG_NewlySpawned = 7,
	}
}