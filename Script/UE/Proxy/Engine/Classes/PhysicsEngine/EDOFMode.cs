using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EDOFMode")]
	public enum EDOFMode : byte
	{
		Default = 0,
		SixDOF = 1,
		YZPlane = 2,
		XZPlane = 3,
		XYPlane = 4,
		CustomPlane = 5,
		None = 6,
	}
}