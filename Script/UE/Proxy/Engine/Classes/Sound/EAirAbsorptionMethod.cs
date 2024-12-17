using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EAirAbsorptionMethod")]
	public enum EAirAbsorptionMethod : byte
	{
		Linear = 0,
		CustomCurve = 1,
	}
}