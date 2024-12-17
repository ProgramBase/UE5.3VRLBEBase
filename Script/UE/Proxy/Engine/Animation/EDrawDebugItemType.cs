using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EDrawDebugItemType")]
	public enum EDrawDebugItemType : long
	{
		DirectionalArrow = 0,
		Sphere = 1,
		Line = 2,
		OnScreenMessage = 3,
		CoordinateSystem = 4,
		Point = 5,
		Circle = 6,
		Cone = 7,
		InWorldMessage = 8,
	}
}