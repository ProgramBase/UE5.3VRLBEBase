using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EProxyNormalComputationMethod")]
	public enum EProxyNormalComputationMethod : byte
	{
		AngleWeighted = 0,
		AreaWeighted = 1,
		EqualWeighted = 2,
	}
}