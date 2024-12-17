using Script.CoreUObject;

namespace Script.SlateCore
{
	[PathName("/Script/SlateCore.ESlateBrushMirrorType")]
	public enum ESlateBrushMirrorType : byte
	{
		NoMirror = 0,
		Horizontal = 1,
		Vertical = 2,
		Both = 3,
	}
}