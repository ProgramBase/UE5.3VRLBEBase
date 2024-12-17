using Script.CoreUObject;

namespace Script.MeshLODToolset
{
	[PathName("/Script/MeshLODToolset.ELODManagerToolActions")]
	public enum ELODManagerToolActions : long
	{
		NoAction = 0,
		MoveHiResToLOD0 = 1,
		DeleteHiResSourceModel = 2,
		RemoveUnreferencedMaterials = 3,
	}
}