using Script.CoreUObject;

namespace Script.Landscape
{
	[PathName("/Script/Landscape.ELandscapeCustomizedCoordType")]
	public enum ELandscapeCustomizedCoordType : byte
	{
		LCCT_None = 0,
		LCCT_CustomUV0 = 1,
		LCCT_CustomUV1 = 2,
		LCCT_CustomUV2 = 3,
		LCCT_WeightMapUV = 4,
	}
}