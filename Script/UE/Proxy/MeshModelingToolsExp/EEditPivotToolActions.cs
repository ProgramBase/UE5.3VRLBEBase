using Script.CoreUObject;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.EEditPivotToolActions")]
	public enum EEditPivotToolActions : long
	{
		NoAction = 0,
		Center = 1,
		Bottom = 2,
		Top = 3,
		Left = 4,
		Right = 5,
		Front = 6,
		Back = 7,
		WorldOrigin = 8,
	}
}