using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EAntiAliasingMethod")]
	public enum EAntiAliasingMethod : byte
	{
		AAM_None = 0,
		AAM_FXAA = 1,
		AAM_TemporalAA = 2,
		AAM_MSAA = 3,
		AAM_TSR = 4,
	}
}