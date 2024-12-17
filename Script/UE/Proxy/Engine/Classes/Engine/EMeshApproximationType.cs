using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EMeshApproximationType")]
	public enum EMeshApproximationType : byte
	{
		MeshAndMaterials = 0,
		MeshShapeOnly = 1,
	}
}