using Script.CoreUObject;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.EAxisList")]
	public enum EAxisList : byte
	{
		None = 0,
		X = 1,
		Y = 2,
		Z = 4,
		Screen = 8,
		XY = 3,
		XZ = 5,
		YZ = 6,
		XYZ = 7,
		All = 15,
		ZRotation = 6,
		Rotate2D = 8,
	}
}