using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EActorUpdateOverlapsMethod")]
	public enum EActorUpdateOverlapsMethod : byte
	{
		UseConfigDefault = 0,
		AlwaysUpdate = 1,
		OnlyUpdateMovable = 2,
		NeverUpdate = 3,
	}
}