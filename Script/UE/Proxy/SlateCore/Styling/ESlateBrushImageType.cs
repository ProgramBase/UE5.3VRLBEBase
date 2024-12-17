using Script.CoreUObject;

namespace Script.SlateCore
{
	[PathName("/Script/SlateCore.ESlateBrushImageType")]
	public enum ESlateBrushImageType : byte
	{
		NoImage = 0,
		FullColor = 1,
		Linear = 2,
		Vector = 3,
	}
}