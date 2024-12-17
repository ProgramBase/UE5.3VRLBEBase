using Script.CoreUObject;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.EEnvQueryStatus")]
	public enum EEnvQueryStatus : byte
	{
		Processing = 0,
		Success = 1,
		Failed = 2,
		Aborted = 3,
		OwnerLost = 4,
		MissingParam = 5,
	}
}