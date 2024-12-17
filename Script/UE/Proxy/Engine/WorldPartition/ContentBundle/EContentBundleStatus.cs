using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EContentBundleStatus")]
	public enum EContentBundleStatus : long
	{
		Registered = 0,
		ReadyToInject = 1,
		FailedToInject = 2,
		ContentInjected = 3,
		Unknown = -1,
	}
}