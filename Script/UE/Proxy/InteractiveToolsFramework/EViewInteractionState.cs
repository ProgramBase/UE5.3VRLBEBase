using Script.CoreUObject;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.EViewInteractionState")]
	public enum EViewInteractionState : long
	{
		None = 0,
		Hovered = 1,
		Focused = 2,
	}
}