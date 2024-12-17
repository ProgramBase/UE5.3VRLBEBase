using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EAdditiveBasePoseType")]
	public enum EAdditiveBasePoseType : byte
	{
		ABPT_None = 0,
		ABPT_RefPose = 1,
		ABPT_AnimScaled = 2,
		ABPT_AnimFrame = 3,
		ABPT_LocalAnimFrame = 4,
	}
}