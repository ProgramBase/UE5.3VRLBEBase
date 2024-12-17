using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ModulationParamMode")]
	public enum ModulationParamMode : byte
	{
		MPM_Normal = 0,
		MPM_Abs = 1,
		MPM_Direct = 2,
	}
}