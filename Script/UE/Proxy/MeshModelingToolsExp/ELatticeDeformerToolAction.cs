using Script.CoreUObject;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.ELatticeDeformerToolAction")]
	public enum ELatticeDeformerToolAction : long
	{
		NoAction = 0,
		Constrain = 1,
		ClearConstraints = 2,
	}
}