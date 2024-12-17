using Script.CoreUObject;

namespace Script.FractureEditor
{
	[PathName("/Script/FractureEditor.EDynamicStateOverrideEnum")]
	public enum EDynamicStateOverrideEnum : byte
	{
		NoOverride = 0,
		Sleeping = 1,
		Kinematic = 2,
		Static = 3,
	}
}