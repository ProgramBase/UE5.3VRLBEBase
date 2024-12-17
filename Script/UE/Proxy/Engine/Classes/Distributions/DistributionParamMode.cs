using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.DistributionParamMode")]
	public enum DistributionParamMode : byte
	{
		DPM_Normal = 0,
		DPM_Abs = 1,
		DPM_Direct = 2,
	}
}