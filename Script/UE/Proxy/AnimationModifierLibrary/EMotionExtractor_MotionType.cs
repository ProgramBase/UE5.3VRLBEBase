using Script.CoreUObject;

namespace Script.AnimationModifierLibrary
{
	[PathName("/Script/AnimationModifierLibrary.EMotionExtractor_MotionType")]
	public enum EMotionExtractor_MotionType : byte
	{
		None = 0,
		Translation = 1,
		Rotation = 2,
		Scale = 4,
		TranslationSpeed = 8,
		RotationSpeed = 16,
	}
}