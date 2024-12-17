using Script.CoreUObject;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.EMeshGroupPaintToolActions")]
	public enum EMeshGroupPaintToolActions : long
	{
		NoAction = 0,
		ClearFrozen = 1,
		FreezeCurrent = 2,
		FreezeOthers = 3,
		GrowCurrent = 4,
		ShrinkCurrent = 5,
		ClearCurrent = 6,
		FloodFillCurrent = 7,
		ClearAll = 8,
	}
}