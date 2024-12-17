using Script.CoreUObject;

namespace Script.FractureEditor
{
	[PathName("/Script/FractureEditor.ESelectionOperation")]
	public enum ESelectionOperation : int
	{
		Replace = 0,
		Add = 1,
		Remove = 2,
	}
}