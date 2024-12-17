using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EWorldContentState")]
	public enum EWorldContentState : long
	{
		NoContent = 0,
		ContentBundleInjected = 1,
	}
}