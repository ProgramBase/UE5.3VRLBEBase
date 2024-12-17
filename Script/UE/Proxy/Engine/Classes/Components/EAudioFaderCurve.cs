using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EAudioFaderCurve")]
	public enum EAudioFaderCurve : byte
	{
		Linear = 0,
		Logarithmic = 1,
		SCurve = 2,
		Sin = 3,
		Count = 4,
	}
}