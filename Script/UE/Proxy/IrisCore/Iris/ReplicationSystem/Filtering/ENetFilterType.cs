using Script.CoreUObject;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.ENetFilterType")]
	public enum ENetFilterType : byte
	{
		PrePoll_Raw = 0,
		PostPoll_FragmentBased = 1,
	}
}