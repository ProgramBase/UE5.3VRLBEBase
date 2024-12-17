using Script.CoreUObject;

namespace Script.AnimationModifierLibrary
{
	[PathName("/Script/AnimationModifierLibrary.EMotionExtractor_MathOperation")]
	public enum EMotionExtractor_MathOperation : byte
	{
		None = 0,
		Addition = 1,
		Subtraction = 2,
		Division = 3,
		Multiplication = 4,
	}
}