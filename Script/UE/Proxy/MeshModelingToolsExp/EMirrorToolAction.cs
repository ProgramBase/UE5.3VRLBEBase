using Script.CoreUObject;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.EMirrorToolAction")]
	public enum EMirrorToolAction : long
	{
		NoAction = 0,
		ShiftToCenter = 1,
		Left = 2,
		Right = 3,
		Up = 4,
		Down = 5,
		Forward = 6,
		Backward = 7,
	}
}