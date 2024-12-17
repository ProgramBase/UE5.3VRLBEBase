using Script.CoreUObject;

namespace Script.ComponentVisualizers
{
	[PathName("/Script/ComponentVisualizers.EShapeAddMode")]
	public enum EShapeAddMode : byte
	{
		AppendAfter = 1,
		AppendBefore = 2,
		InsertAfter = 4,
		InsertBefore = 8,
	}
}