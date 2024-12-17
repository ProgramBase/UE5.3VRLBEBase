using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ESettingsDOF")]
	public enum ESettingsDOF : byte
	{
		Full3D = 0,
		YZPlane = 1,
		XZPlane = 2,
		XYPlane = 3,
	}
}