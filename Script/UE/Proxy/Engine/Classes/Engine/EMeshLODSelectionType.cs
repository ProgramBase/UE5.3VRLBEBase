using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EMeshLODSelectionType")]
	public enum EMeshLODSelectionType : byte
	{
		AllLODs = 0,
		SpecificLOD = 1,
		CalculateLOD = 2,
		LowestDetailLOD = 3,
	}
}