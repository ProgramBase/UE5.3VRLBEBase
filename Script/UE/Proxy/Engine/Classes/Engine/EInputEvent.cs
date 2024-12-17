using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EInputEvent")]
	public enum EInputEvent : byte
	{
		IE_Pressed = 0,
		IE_Released = 1,
		IE_Repeat = 2,
		IE_DoubleClick = 3,
		IE_Axis = 4,
	}
}