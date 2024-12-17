using Script.CoreUObject;

namespace Script.InterchangeNodes
{
	[PathName("/Script/InterchangeNodes.EInterchangeLightUnits")]
	public enum EInterchangeLightUnits : byte
	{
		Unitless = 0,
		Candelas = 1,
		Lumens = 2,
		EV = 3,
	}
}