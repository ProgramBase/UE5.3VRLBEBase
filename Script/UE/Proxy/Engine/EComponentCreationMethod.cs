using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EComponentCreationMethod")]
	public enum EComponentCreationMethod : byte
	{
		Native = 0,
		SimpleConstructionScript = 1,
		UserConstructionScript = 2,
		Instance = 3,
	}
}