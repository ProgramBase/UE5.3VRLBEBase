using Script.CoreUObject;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.EDrawPolyPathExtrudeMode")]
	public enum EDrawPolyPathExtrudeMode : int
	{
		Flat = 0,
		Fixed = 1,
		Interactive = 2,
		RampFixed = 3,
		RampInteractive = 4,
	}
}