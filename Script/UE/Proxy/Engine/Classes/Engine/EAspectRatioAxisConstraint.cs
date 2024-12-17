using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EAspectRatioAxisConstraint")]
	public enum EAspectRatioAxisConstraint : byte
	{
		AspectRatio_MaintainYFOV = 0,
		AspectRatio_MaintainXFOV = 1,
		AspectRatio_MajorAxisFOV = 2,
	}
}