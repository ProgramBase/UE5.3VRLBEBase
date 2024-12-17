using Script.CoreUObject;

namespace Script.ViewportInteraction
{
	[PathName("/Script/ViewportInteraction.EHitResultGizmoFilterMode")]
	public enum EHitResultGizmoFilterMode : byte
	{
		All = 0,
		NoGizmos = 1,
		GizmosOnly = 2,
	}
}