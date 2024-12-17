using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.Beam2SourceTargetTangentMethod")]
	public enum Beam2SourceTargetTangentMethod : byte
	{
		PEB2STTM_Direct = 0,
		PEB2STTM_UserSet = 1,
		PEB2STTM_Distribution = 2,
		PEB2STTM_Emitter = 3,
	}
}