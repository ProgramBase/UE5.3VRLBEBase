using Script.CoreUObject;

namespace Script.ModelingOperatorsEditorOnly
{
	[PathName("/Script/ModelingOperatorsEditorOnly.ESimplifyTargetType")]
	public enum ESimplifyTargetType : byte
	{
		Percentage = 0,
		TriangleCount = 1,
		VertexCount = 2,
		EdgeLength = 3,
		MinimalPlanar = 4,
	}
}