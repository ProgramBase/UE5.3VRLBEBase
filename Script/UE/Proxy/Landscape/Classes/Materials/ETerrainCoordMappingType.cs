using Script.CoreUObject;

namespace Script.Landscape
{
	[PathName("/Script/Landscape.ETerrainCoordMappingType")]
	public enum ETerrainCoordMappingType : byte
	{
		TCMT_Auto = 0,
		TCMT_XY = 1,
		TCMT_XZ = 2,
		TCMT_YZ = 3,
	}
}