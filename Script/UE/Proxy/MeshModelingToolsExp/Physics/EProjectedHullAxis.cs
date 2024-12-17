using Script.CoreUObject;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.EProjectedHullAxis")]
	public enum EProjectedHullAxis : int
	{
		X = 0,
		Y = 1,
		Z = 2,
		SmallestBoxDimension = 3,
		SmallestVolume = 4,
	}
}