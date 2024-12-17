using Script.CoreUObject;

namespace Script.ModelingComponentsEditorOnly
{
	[PathName("/Script/ModelingComponentsEditorOnly.ESubdivisionOutputNormals")]
	public enum ESubdivisionOutputNormals : byte
	{
		Interpolated = 0,
		Generated = 1,
		None = 2,
	}
}