using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EPlaneConstraintAxisSetting")]
	public enum EPlaneConstraintAxisSetting : byte
	{
		Custom = 0,
		X = 1,
		Y = 2,
		Z = 3,
		UseGlobalPhysicsSetting = 4,
	}
}