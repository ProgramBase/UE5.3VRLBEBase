using Script.CoreUObject;

namespace Script.FractureEditor
{
	[PathName("/Script/FractureEditor.ETargetFaces")]
	public enum ETargetFaces : int
	{
		InternalFaces = 0,
		InternalFacesAndSelectedMaterialIDs = 1,
		SelectedMaterialIDs = 2,
		ExternalFaces = 3,
		AllFaces = 4,
	}
}