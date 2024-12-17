using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EMaterialVectorCoordTransform")]
	public enum EMaterialVectorCoordTransform : byte
	{
		TRANSFORM_Tangent = 0,
		TRANSFORM_Local = 1,
		TRANSFORM_World = 2,
		TRANSFORM_View = 3,
		TRANSFORM_Camera = 4,
		TRANSFORM_ParticleWorld = 5,
		TRANSFORM_Instance = 6,
	}
}