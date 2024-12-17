using Script.CoreUObject;

namespace Script.Slate
{
	[PathName("/Script/Slate.EScrollWhenFocusChanges")]
	public enum EScrollWhenFocusChanges : byte
	{
		NoScroll = 0,
		InstantScroll = 1,
		AnimatedScroll = 2,
	}
}