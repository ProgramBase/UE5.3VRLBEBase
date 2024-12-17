using Script.CoreUObject;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.AnimPhysSimSpaceType")]
	public enum AnimPhysSimSpaceType : byte
	{
		Component = 0,
		Actor = 1,
		World = 2,
		RootRelative = 3,
		BoneRelative = 4,
	}
}