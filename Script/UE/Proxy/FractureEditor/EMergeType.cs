using Script.CoreUObject;

namespace Script.FractureEditor
{
	[PathName("/Script/FractureEditor.EMergeType")]
	public enum EMergeType : byte
	{
		MergeGeometry = 0,
		MergeClusters = 1,
	}
}