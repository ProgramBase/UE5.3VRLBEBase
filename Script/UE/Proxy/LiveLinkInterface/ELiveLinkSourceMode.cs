using Script.CoreUObject;

namespace Script.LiveLinkInterface
{
	[PathName("/Script/LiveLinkInterface.ELiveLinkSourceMode")]
	public enum ELiveLinkSourceMode : byte
	{
		Latest = 0,
		EngineTime = 1,
		Timecode = 2,
	}
}