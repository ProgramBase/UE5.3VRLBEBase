using Script.CoreUObject;

namespace Script.InterchangeTests
{
	[PathName("/Script/InterchangeTests.EStaticMeshImportTestGroundTruthBitflags")]
	public enum EStaticMeshImportTestGroundTruthBitflags : long
	{
		CheckLodCountEqual = 1,
		CheckVertexCountEqual = 2,
		CheckTriangleCountEqual = 4,
		CheckUVChannelCountEqual = 8,
		CheckCollisionPrimitiveCountEqual = 16,
		CheckVertexPositionsEqual = 32,
		CheckNormalsEqual = 64,
	}
}