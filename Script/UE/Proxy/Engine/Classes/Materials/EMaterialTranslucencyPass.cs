using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EMaterialTranslucencyPass")]
	public enum EMaterialTranslucencyPass : byte
	{
		MTP_BeforeDOF = 0,
		MTP_AfterDOF = 1,
		MTP_AfterMotionBlur = 2,
	}
}