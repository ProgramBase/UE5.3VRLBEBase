using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ENodeEnabledState")]
	public enum ENodeEnabledState : byte
	{
		Enabled = 0,
		Disabled = 1,
		DevelopmentOnly = 2,
	}
}