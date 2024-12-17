using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ENormalMode")]
	public enum ENormalMode : long
	{
		NM_PreserveSmoothingGroups = 0,
		NM_RecalculateNormals = 1,
		NM_RecalculateNormalsSmooth = 2,
		NM_RecalculateNormalsHard = 3,
		TEMP_BROKEN = 4,
	}
}