using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EEmitterDynamicParameterValue")]
	public enum EEmitterDynamicParameterValue : byte
	{
		EDPV_UserSet = 0,
		EDPV_AutoSet = 1,
		EDPV_VelocityX = 2,
		EDPV_VelocityY = 3,
		EDPV_VelocityZ = 4,
		EDPV_VelocityMag = 5,
	}
}