using Script.CoreUObject;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.EMeshSculptFalloffType")]
	public enum EMeshSculptFalloffType : byte
	{
		Smooth = 0,
		Linear = 1,
		Inverse = 2,
		Round = 3,
		BoxSmooth = 4,
		BoxLinear = 5,
		BoxInverse = 6,
		BoxRound = 7,
		LastValue = 8,
	}
}