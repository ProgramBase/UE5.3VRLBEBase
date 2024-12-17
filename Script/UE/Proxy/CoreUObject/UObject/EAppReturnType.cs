using Script.CoreUObject;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.EAppReturnType")]
	public enum EAppReturnType : byte
	{
		No = 0,
		Yes = 1,
		YesAll = 2,
		NoAll = 3,
		Cancel = 4,
		Ok = 5,
		Retry = 6,
		Continue = 7,
	}
}