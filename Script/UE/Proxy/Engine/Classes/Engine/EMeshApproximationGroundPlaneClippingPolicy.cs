using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EMeshApproximationGroundPlaneClippingPolicy")]
	public enum EMeshApproximationGroundPlaneClippingPolicy : byte
	{
		NoGroundClipping = 0,
		DiscardWithZPlane = 1,
		CutWithZPlane = 2,
		CutAndFillWithZPlane = 3,
	}
}