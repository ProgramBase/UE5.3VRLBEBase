using Script.CoreUObject;

namespace Script.Slate
{
	[PathName("/Script/Slate.EDescendantScrollDestination")]
	public enum EDescendantScrollDestination : byte
	{
		IntoView = 0,
		TopOrLeft = 1,
		Center = 2,
		BottomOrRight = 3,
	}
}