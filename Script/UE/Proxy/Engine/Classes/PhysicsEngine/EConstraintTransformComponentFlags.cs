using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EConstraintTransformComponentFlags")]
	public enum EConstraintTransformComponentFlags : byte
	{
		None = 0,
		ChildPosition = 1,
		ChildRotation = 2,
		ParentPosition = 4,
		ParentRotation = 8,
		AllChild = 3,
		AllParent = 12,
		AllPosition = 5,
		AllRotation = 10,
		All = 15,
	}
}