using Script.CoreUObject;

namespace Script.PinnedCommandList
{
	[PathName("/Script/PinnedCommandList.EPinnedCommandListType")]
	public enum EPinnedCommandListType : byte
	{
		Command = 0,
		CustomWidget = 1,
	}
}