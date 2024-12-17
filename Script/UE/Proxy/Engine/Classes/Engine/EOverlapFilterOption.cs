using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EOverlapFilterOption")]
	public enum EOverlapFilterOption : long
	{
		OverlapFilter_All = 0,
		OverlapFilter_DynamicOnly = 1,
		OverlapFilter_StaticOnly = 2,
	}
}