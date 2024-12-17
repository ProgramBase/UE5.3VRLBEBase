using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EMicroTransactionResult")]
	public enum EMicroTransactionResult : long
	{
		MTR_Succeeded = 0,
		MTR_Failed = 1,
		MTR_Canceled = 2,
		MTR_RestoredFromServer = 3,
	}
}