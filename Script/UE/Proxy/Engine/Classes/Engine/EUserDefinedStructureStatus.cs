using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EUserDefinedStructureStatus")]
	public enum EUserDefinedStructureStatus : byte
	{
		UDSS_UpToDate = 0,
		UDSS_Dirty = 1,
		UDSS_Error = 2,
		UDSS_Duplicate = 3,
	}
}