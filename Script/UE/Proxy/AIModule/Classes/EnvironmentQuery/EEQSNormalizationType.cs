using Script.CoreUObject;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.EEQSNormalizationType")]
	public enum EEQSNormalizationType : byte
	{
		Absolute = 0,
		RelativeToScores = 1,
	}
}