using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENiagaraCullReaction")]
	public enum ENiagaraCullReaction : int
	{
		Deactivate = 0,
		DeactivateImmediate = 1,
		DeactivateResume = 2,
		DeactivateImmediateResume = 3,
		PauseResume = 4,
	}
}