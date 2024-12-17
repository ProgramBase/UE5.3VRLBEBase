using Script.CoreUObject;

namespace Script.HotPatcherRuntime
{
	[PathName("/Script/HotPatcherRuntime.EHashCalculator")]
	public enum EHashCalculator : int
	{
		NoHash = 0,
		MD5 = 1,
		SHA1 = 2,
	}
}