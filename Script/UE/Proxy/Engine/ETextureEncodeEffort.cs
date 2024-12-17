using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ETextureEncodeEffort")]
	public enum ETextureEncodeEffort : byte
	{
		Default = 0,
		Low = 10,
		Normal = 20,
		High = 30,
	}
}