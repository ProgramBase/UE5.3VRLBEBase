using Script.CoreUObject;

namespace Script.ModelingComponentsEditorOnly
{
	[PathName("/Script/ModelingComponentsEditorOnly.ESubdivisionScheme")]
	public enum ESubdivisionScheme : byte
	{
		Bilinear = 0,
		CatmullClark = 1,
		Loop = 2,
	}
}