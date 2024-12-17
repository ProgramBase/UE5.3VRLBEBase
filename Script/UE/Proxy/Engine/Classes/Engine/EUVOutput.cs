using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EUVOutput")]
	public enum EUVOutput : byte
	{
		DoNotOutputChannel = 0,
		OutputChannel = 1,
	}
}