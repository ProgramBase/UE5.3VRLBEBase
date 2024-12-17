using Script.CoreUObject;

namespace Script.MeshPaintEditorMode
{
	[PathName("/Script/MeshPaintEditorMode.EMeshPaintActiveMode")]
	public enum EMeshPaintActiveMode : long
	{
		Color = 0,
		Weights = 1,
		Texture = 2,
	}
}