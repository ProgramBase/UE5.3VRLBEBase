using Script.CoreUObject;

namespace Script.SlateCore
{
	[PathName("/Script/SlateCore.ESlateBrushDrawType")]
	public enum ESlateBrushDrawType : byte
	{
		NoDrawType = 0,
		Box = 1,
		Border = 2,
		Image = 3,
		RoundedBox = 4,
	}
}