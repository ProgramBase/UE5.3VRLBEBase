using Script.CoreUObject;

namespace Script.MediaAssets
{
	[PathName("/Script/MediaAssets.EMediaPlayerTrack")]
	public enum EMediaPlayerTrack : byte
	{
		Audio = 0,
		Caption = 1,
		Metadata = 2,
		Script = 3,
		Subtitle = 4,
		Text = 5,
		Video = 6,
	}
}