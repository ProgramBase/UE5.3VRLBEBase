using Script.CoreUObject;

namespace Script.SlateCore
{
	[PathName("/Script/SlateCore.ETextShapingMethod")]
	public enum ETextShapingMethod : byte
	{
		Auto = 0,
		KerningOnly = 1,
		FullShaping = 2,
	}
}