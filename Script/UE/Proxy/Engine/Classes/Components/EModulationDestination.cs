using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EModulationDestination")]
	public enum EModulationDestination : byte
	{
		Volume = 0,
		Pitch = 1,
		Lowpass = 2,
		Highpass = 3,
		Count = 4,
	}
}