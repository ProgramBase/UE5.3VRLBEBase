using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EWorkingColorSpace")]
	public enum EWorkingColorSpace : byte
	{
		sRGB = 1,
		Rec2020 = 2,
		ACESAP0 = 3,
		ACESAP1 = 4,
		P3DCI = 5,
		P3D65 = 6,
		Custom = 7,
	}
}