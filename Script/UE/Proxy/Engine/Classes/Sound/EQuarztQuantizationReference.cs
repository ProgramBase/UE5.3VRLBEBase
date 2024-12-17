using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EQuarztQuantizationReference")]
	public enum EQuarztQuantizationReference : byte
	{
		BarRelative = 0,
		TransportRelative = 1,
		CurrentTimeRelative = 2,
		Count = 3,
	}
}