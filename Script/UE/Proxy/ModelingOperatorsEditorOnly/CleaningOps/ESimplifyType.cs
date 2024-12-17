using Script.CoreUObject;

namespace Script.ModelingOperatorsEditorOnly
{
	[PathName("/Script/ModelingOperatorsEditorOnly.ESimplifyType")]
	public enum ESimplifyType : byte
	{
		QEM = 0,
		Attribute = 1,
		UEStandard = 2,
		MinimalExistingVertex = 3,
		MinimalPlanar = 4,
		MinimalPolygroup = 5,
	}
}