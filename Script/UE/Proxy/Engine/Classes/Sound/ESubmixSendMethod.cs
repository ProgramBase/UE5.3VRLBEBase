using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ESubmixSendMethod")]
	public enum ESubmixSendMethod : byte
	{
		Linear = 0,
		CustomCurve = 1,
		Manual = 2,
	}
}