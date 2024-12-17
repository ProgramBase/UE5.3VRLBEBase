using Script.CoreUObject;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.EPropertyAccessChangeNotifyMode")]
	public enum EPropertyAccessChangeNotifyMode : byte
	{
		Default = 0,
		Never = 1,
		Always = 2,
	}
}