using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EMeshScreenAlignment")]
	public enum EMeshScreenAlignment : byte
	{
		PSMA_MeshFaceCameraWithRoll = 0,
		PSMA_MeshFaceCameraWithSpin = 1,
		PSMA_MeshFaceCameraWithLockedAxis = 2,
	}
}