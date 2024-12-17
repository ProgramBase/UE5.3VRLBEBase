using Script.CoreUObject;

namespace Script.FractureEditor
{
	[PathName("/Script/FractureEditor.EGeometrySelectionMethod")]
	public enum EGeometrySelectionMethod : int
	{
		VolumeCubeRoot = 0,
		RelativeVolume = 1,
	}
}