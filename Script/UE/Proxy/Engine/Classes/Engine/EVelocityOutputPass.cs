using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EVelocityOutputPass")]
	public enum EVelocityOutputPass : byte
	{
		DepthPass = 0,
		BasePass = 1,
		AfterBasePass = 2,
	}
}