using Script.CoreUObject;

namespace Script.FractureEditor
{
	[PathName("/Script/FractureEditor.EOutlinerColumnMode")]
	public enum EOutlinerColumnMode : byte
	{
		State = 0,
		Damage = 1,
		Removal = 2,
		Collision = 3,
		Size = 4,
	}
}