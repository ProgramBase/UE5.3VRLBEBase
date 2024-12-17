using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EFullyLoadPackageType")]
	public enum EFullyLoadPackageType : byte
	{
		FULLYLOAD_Map = 0,
		FULLYLOAD_Game_PreLoadClass = 1,
		FULLYLOAD_Game_PostLoadClass = 2,
		FULLYLOAD_Always = 3,
		FULLYLOAD_Mutator = 4,
	}
}