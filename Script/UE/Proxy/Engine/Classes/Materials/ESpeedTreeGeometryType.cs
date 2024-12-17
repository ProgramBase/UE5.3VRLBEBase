using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ESpeedTreeGeometryType")]
	public enum ESpeedTreeGeometryType : byte
	{
		STG_Branch = 0,
		STG_Frond = 1,
		STG_Leaf = 2,
		STG_FacingLeaf = 3,
		STG_Billboard = 4,
	}
}