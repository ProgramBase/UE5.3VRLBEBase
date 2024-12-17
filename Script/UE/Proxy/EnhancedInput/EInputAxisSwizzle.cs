using Script.CoreUObject;

namespace Script.EnhancedInput
{
	[PathName("/Script/EnhancedInput.EInputAxisSwizzle")]
	public enum EInputAxisSwizzle : byte
	{
		YXZ = 0,
		ZYX = 1,
		XZY = 2,
		YZX = 3,
		ZXY = 4,
	}
}