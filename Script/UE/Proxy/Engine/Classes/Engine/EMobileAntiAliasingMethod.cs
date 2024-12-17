using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EMobileAntiAliasingMethod")]
	public enum EMobileAntiAliasingMethod : byte
	{
		None = 0,
		FXAA = 1,
		TemporalAA = 2,
		MSAA = 3,
	}
}