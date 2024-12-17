using Script.CoreUObject;

namespace Script.MRMesh
{
	[PathName("/Script/MRMesh.EMeshTrackerVertexColorMode")]
	public enum EMeshTrackerVertexColorMode : byte
	{
		None = 0,
		Confidence = 1,
		Block = 2,
	}
}