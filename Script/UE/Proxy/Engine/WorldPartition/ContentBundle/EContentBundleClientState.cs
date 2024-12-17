using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EContentBundleClientState")]
	public enum EContentBundleClientState : long
	{
		Unregistered = 0,
		Registered = 1,
		ContentInjectionRequested = 2,
		ContentRemovalRequested = 3,
		RegistrationFailed = 4,
	}
}