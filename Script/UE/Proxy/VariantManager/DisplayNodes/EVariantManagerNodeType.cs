using Script.CoreUObject;

namespace Script.VariantManager
{
	[PathName("/Script/VariantManager.EVariantManagerNodeType")]
	public enum EVariantManagerNodeType : long
	{
		VariantSet = 0,
		Variant = 1,
		Actor = 2,
		Property = 3,
		Function = 4,
		Spacer = 5,
	}
}