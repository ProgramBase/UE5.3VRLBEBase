using Script.CoreUObject;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.EPawnActionFailHandling")]
	public enum EPawnActionFailHandling : byte
	{
		RequireSuccess = 0,
		IgnoreFailure = 1,
	}
}