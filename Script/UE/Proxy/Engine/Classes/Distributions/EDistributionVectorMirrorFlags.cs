using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EDistributionVectorMirrorFlags")]
	public enum EDistributionVectorMirrorFlags : byte
	{
		EDVMF_Same = 0,
		EDVMF_Different = 1,
		EDVMF_Mirror = 2,
	}
}