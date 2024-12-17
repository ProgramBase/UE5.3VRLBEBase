using Script.CoreUObject;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.EPatternToolAxisSpacingMode")]
	public enum EPatternToolAxisSpacingMode : byte
	{
		ByCount = 0,
		StepSize = 1,
		Packed = 2,
	}
}