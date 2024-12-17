using Script.CoreUObject;

namespace Script.FractureEditor
{
	[PathName("/Script/FractureEditor.EVolumeSelectionMethod")]
	public enum EVolumeSelectionMethod : int
	{
		CubeRootOfVolume = 0,
		RelativeToWhole = 1,
		RelativeToLargest = 2,
	}
}