using Script.CoreUObject;

namespace Script.AnimationCore
{
	[PathName("/Script/AnimationCore.ETransformConstraintType")]
	public enum ETransformConstraintType : byte
	{
		Translation = 0,
		Rotation = 1,
		Scale = 2,
		Parent = 3,
		LookAt = 4,
	}
}