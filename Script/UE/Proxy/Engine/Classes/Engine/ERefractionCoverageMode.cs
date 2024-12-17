using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ERefractionCoverageMode")]
	public enum ERefractionCoverageMode : byte
	{
		RCM_CoverageIgnored = 0,
		RCM_CoverageAccountedFor = 1,
	}
}