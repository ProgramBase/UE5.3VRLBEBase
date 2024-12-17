using Script.CoreUObject;

namespace Script.VREditor
{
	[PathName("/Script/VREditor.EControllerType")]
	public enum EControllerType : byte
	{
		Laser = 0,
		AssistingLaser = 1,
		UI = 2,
		Navigation = 3,
		Unknown = 4,
	}
}