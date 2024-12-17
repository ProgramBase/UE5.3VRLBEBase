using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EBrushType")]
	public enum EBrushType : byte
	{
		Brush_Default = 0,
		Brush_Add = 1,
		Brush_Subtract = 2,
	}
}