using Script.CoreUObject;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.EWarpingVectorMode")]
	public enum EWarpingVectorMode : byte
	{
		ComponentSpaceVector = 0,
		ActorSpaceVector = 1,
		WorldSpaceVector = 2,
		IKFootRootLocalSpaceVector = 3,
	}
}