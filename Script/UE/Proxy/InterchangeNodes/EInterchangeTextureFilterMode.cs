using Script.CoreUObject;

namespace Script.InterchangeNodes
{
	[PathName("/Script/InterchangeNodes.EInterchangeTextureFilterMode")]
	public enum EInterchangeTextureFilterMode : byte
	{
		Nearest = 0,
		Bilinear = 1,
		Trilinear = 2,
		Default = 3,
	}
}