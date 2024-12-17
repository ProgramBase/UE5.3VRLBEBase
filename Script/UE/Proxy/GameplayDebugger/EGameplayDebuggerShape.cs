using Script.CoreUObject;

namespace Script.GameplayDebugger
{
	[PathName("/Script/GameplayDebugger.EGameplayDebuggerShape")]
	public enum EGameplayDebuggerShape : byte
	{
		Invalid = 0,
		Point = 1,
		Segment = 2,
		Box = 3,
		Cone = 4,
		Cylinder = 5,
		Circle = 6,
		Rectangle = 7,
		Capsule = 8,
		Polygon = 9,
		Polyline = 10,
		Arrow = 11,
	}
}