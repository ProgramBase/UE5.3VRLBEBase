using Script.CoreUObject;

namespace Script.ModelingComponents
{
	[PathName("/Script/ModelingComponents.EGeometrySelectionElementType")]
	public enum EGeometrySelectionElementType : byte
	{
		Vertex = 1,
		Edge = 2,
		Face = 4,
	}
}