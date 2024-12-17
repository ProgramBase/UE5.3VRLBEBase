using Script.CoreUObject;

namespace Script.MeshDescription
{
	[PathName("/Script/MeshDescription.EComputeNTBsOptions")]
	public enum EComputeNTBsOptions : long
	{
		None = 0,
		Normals = 1,
		Tangents = 2,
		WeightedNTBs = 4,
	}
}