using Script.CoreUObject;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.EBakeCurvatureClampMode")]
	public enum EBakeCurvatureClampMode : int
	{
		None = 0,
		OnlyPositive = 1,
		OnlyNegative = 2,
	}
}