using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENDICollisionQuery_AsyncGpuTraceProvider")]
	public enum ENDICollisionQuery_AsyncGpuTraceProvider : byte
	{
		Default = 0,
		HWRT = 1,
		GSDF = 2,
		None = 3,
	}
}