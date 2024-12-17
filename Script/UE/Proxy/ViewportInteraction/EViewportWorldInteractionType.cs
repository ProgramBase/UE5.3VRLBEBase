using Script.CoreUObject;

namespace Script.ViewportInteraction
{
	[PathName("/Script/ViewportInteraction.EViewportWorldInteractionType")]
	public enum EViewportWorldInteractionType : long
	{
		VR = 0,
		Legacy = 1,
	}
}