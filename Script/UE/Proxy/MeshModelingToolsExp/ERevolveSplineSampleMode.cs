using Script.CoreUObject;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.ERevolveSplineSampleMode")]
	public enum ERevolveSplineSampleMode : byte
	{
		ControlPointsOnly = 0,
		PolyLineMaxError = 1,
		UniformSpacingAlongCurve = 2,
	}
}