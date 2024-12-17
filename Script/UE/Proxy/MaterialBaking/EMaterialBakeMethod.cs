using Script.CoreUObject;

namespace Script.MaterialBaking
{
	[PathName("/Script/MaterialBaking.EMaterialBakeMethod")]
	public enum EMaterialBakeMethod : byte
	{
		IndividualMaterial = 0,
		AtlasMaterial = 1,
		BinnedMaterial = 2,
	}
}