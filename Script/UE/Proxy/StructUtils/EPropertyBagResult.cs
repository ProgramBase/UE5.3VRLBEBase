using Script.CoreUObject;

namespace Script.StructUtils
{
	[PathName("/Script/StructUtils.EPropertyBagResult")]
	public enum EPropertyBagResult : long
	{
		Success = 0,
		TypeMismatch = 1,
		OutOfBounds = 2,
		PropertyNotFound = 3,
	}
}