using Script.CoreUObject;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.ESmoothMeshToolSmoothType")]
	public enum ESmoothMeshToolSmoothType : byte
	{
		Iterative = 0,
		Implicit = 1,
		Diffusion = 2,
	}
}