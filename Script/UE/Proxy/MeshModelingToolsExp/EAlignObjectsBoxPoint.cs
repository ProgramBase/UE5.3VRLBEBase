using Script.CoreUObject;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.EAlignObjectsBoxPoint")]
	public enum EAlignObjectsBoxPoint : int
	{
		Center = 0,
		Bottom = 1,
		Top = 2,
		Left = 3,
		Right = 4,
		Front = 5,
		Back = 6,
		Min = 7,
		Max = 8,
	}
}