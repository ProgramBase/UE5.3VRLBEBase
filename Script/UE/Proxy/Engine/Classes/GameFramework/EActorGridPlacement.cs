using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EActorGridPlacement")]
	public enum EActorGridPlacement : long
	{
		Bounds = 0,
		Location = 1,
		AlwaysLoaded = 2,
		None = 3,
	}
}