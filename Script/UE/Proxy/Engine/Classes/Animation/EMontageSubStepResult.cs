using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EMontageSubStepResult")]
	public enum EMontageSubStepResult : long
	{
		Moved = 0,
		NotMoved = 1,
		InvalidSection = 2,
		InvalidMontage = 3,
	}
}