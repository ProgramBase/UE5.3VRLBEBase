using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EBoneRotationSource")]
	public enum EBoneRotationSource : byte
	{
		BRS_KeepComponentSpaceRotation = 0,
		BRS_KeepLocalSpaceRotation = 1,
		BRS_CopyFromTarget = 2,
	}
}