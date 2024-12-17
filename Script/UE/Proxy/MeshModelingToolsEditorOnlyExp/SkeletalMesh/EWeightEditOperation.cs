using Script.CoreUObject;

namespace Script.MeshModelingToolsEditorOnlyExp
{
	[PathName("/Script/MeshModelingToolsEditorOnlyExp.EWeightEditOperation")]
	public enum EWeightEditOperation : byte
	{
		Add = 0,
		Replace = 1,
		Multiply = 2,
		Relax = 3,
	}
}