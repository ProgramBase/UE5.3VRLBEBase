using Script.CoreUObject;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.EEnvTestFilterType")]
	public enum EEnvTestFilterType : byte
	{
		Minimum = 0,
		Maximum = 1,
		Range = 2,
		Match = 3,
	}
}