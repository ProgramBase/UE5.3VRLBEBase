using Script.CoreUObject;

namespace Script.ModelingOperatorsEditorOnly
{
	[PathName("/Script/ModelingOperatorsEditorOnly.EMeshTangentsType")]
	public enum EMeshTangentsType : byte
	{
		MikkTSpace = 0,
		FastMikkTSpace = 1,
		PerTriangle = 2,
		CopyExisting = 3,
	}
}