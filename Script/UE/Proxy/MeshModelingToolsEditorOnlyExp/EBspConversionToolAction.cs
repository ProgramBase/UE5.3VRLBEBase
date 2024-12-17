using Script.CoreUObject;

namespace Script.MeshModelingToolsEditorOnlyExp
{
	[PathName("/Script/MeshModelingToolsEditorOnlyExp.EBspConversionToolAction")]
	public enum EBspConversionToolAction : long
	{
		NoAction = 0,
		SelectAllValidBrushes = 1,
		DeselectVolumes = 2,
		DeselectNonValid = 3,
	}
}