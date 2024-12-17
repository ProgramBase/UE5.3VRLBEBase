using Script.CoreUObject;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.ERBFVectorDistanceType")]
	public enum ERBFVectorDistanceType : byte
	{
		Euclidean = 0,
		Manhattan = 1,
		ArcLength = 2,
	}
}