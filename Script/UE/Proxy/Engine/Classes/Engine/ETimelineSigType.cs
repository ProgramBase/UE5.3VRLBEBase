using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ETimelineSigType")]
	public enum ETimelineSigType : long
	{
		ETS_EventSignature = 0,
		ETS_FloatSignature = 1,
		ETS_VectorSignature = 2,
		ETS_LinearColorSignature = 3,
		ETS_InvalidSignature = 4,
	}
}