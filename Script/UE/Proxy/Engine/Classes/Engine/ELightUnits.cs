using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ELightUnits")]
	public enum ELightUnits : byte
	{
		Unitless = 0,
		Candelas = 1,
		Lumens = 2,
		EV = 3,
	}
}