using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EAudioOutputTarget")]
	public enum EAudioOutputTarget : byte
	{
		Speaker = 0,
		Controller = 1,
		ControllerFallbackToSpeaker = 2,
	}
}