using Script.CoreUObject;

namespace Script.Synthesis
{
	[PathName("/Script/Synthesis.ETapLineMode")]
	public enum ETapLineMode : byte
	{
		SendToChannel = 0,
		Panning = 1,
		Disabled = 2,
	}
}