using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EAudioVolumeLocationState")]
	public enum EAudioVolumeLocationState : byte
	{
		InsideTheVolume = 0,
		OutsideTheVolume = 1,
	}
}