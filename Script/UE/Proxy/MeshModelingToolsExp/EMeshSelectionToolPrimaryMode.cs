using Script.CoreUObject;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.EMeshSelectionToolPrimaryMode")]
	public enum EMeshSelectionToolPrimaryMode : int
	{
		Brush = 0,
		VolumetricBrush = 1,
		AngleFiltered = 2,
		Visible = 3,
		AllConnected = 4,
		AllInGroup = 5,
		ByMaterial = 6,
		ByMaterialAll = 7,
		ByUVIsland = 8,
		AllWithinAngle = 9,
	}
}