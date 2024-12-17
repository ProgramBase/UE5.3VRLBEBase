using Script.CoreUObject;

namespace Script.InterchangeNodes
{
	[PathName("/Script/InterchangeNodes.EInterchangeTextureWrapMode")]
	public enum EInterchangeTextureWrapMode : byte
	{
		Wrap = 0,
		Clamp = 1,
		Mirror = 2,
	}
}