using Script.CoreUObject;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.EAppMsgType")]
	public enum EAppMsgType : byte
	{
		Ok = 0,
		YesNo = 1,
		OkCancel = 2,
		YesNoCancel = 3,
		CancelRetryContinue = 4,
		YesNoYesAllNoAll = 5,
		YesNoYesAllNoAllCancel = 6,
		YesNoYesAll = 7,
	}
}