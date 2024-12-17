using Script.CoreUObject;

namespace Script.MeshLODToolset
{
	[PathName("/Script/MeshLODToolset.EGenerateStaticMeshLODProjectedHullAxisMode")]
	public enum EGenerateStaticMeshLODProjectedHullAxisMode : byte
	{
		X = 0,
		Y = 1,
		Z = 2,
		SmallestBoxDimension = 3,
		SmallestVolume = 4,
	}
}