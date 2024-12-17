using Script.CoreUObject;

namespace Script.MediaAssets
{
	[PathName("/Script/MediaAssets.MediaTextureOutputFormat")]
	public enum MediaTextureOutputFormat : byte
	{
		MTOF_Default = 0,
		MTOF_SRGB_LINOUT = 1,
	}
}