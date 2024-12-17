using Script.CoreUObject;

namespace Script.FractureEditor
{
	[PathName("/Script/FractureEditor.ENeighborSelectionMethod")]
	public enum ENeighborSelectionMethod : int
	{
		LargestNeighbor = 0,
		NearestCenter = 1,
	}
}