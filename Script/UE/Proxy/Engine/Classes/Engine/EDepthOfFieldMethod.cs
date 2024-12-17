using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EDepthOfFieldMethod")]
	public enum EDepthOfFieldMethod : long
	{
		DOFM_BokehDOF = 0,
		DOFM_Gaussian = 1,
		DOFM_CircleDOF = 2,
	}
}