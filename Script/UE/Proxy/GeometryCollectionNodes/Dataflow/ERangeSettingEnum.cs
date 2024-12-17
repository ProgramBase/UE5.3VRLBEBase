using Script.CoreUObject;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.ERangeSettingEnum")]
	public enum ERangeSettingEnum : byte
	{
		Dataflow_RangeSetting_InsideRange = 0,
		Dataflow_RangeSetting_OutsideRange = 1,
		Dataflow_Max = 2,
	}
}