using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EOrbitChainMode")]
	public enum EOrbitChainMode : byte
	{
		EOChainMode_Add = 0,
		EOChainMode_Scale = 1,
		EOChainMode_Link = 2,
	}
}