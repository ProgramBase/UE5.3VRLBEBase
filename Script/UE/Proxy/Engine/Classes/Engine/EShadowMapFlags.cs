using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EShadowMapFlags")]
	public enum EShadowMapFlags : byte
	{
		SMF_None = 0,
		SMF_Streamed = 1,
	}
}