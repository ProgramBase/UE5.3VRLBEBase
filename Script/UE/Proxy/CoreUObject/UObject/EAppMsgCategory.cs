using Script.CoreUObject;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.EAppMsgCategory")]
	public enum EAppMsgCategory : byte
	{
		Warning = 0,
		Error = 1,
		Success = 2,
		Info = 3,
	}
}