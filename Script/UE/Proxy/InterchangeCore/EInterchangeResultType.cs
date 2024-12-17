using Script.CoreUObject;

namespace Script.InterchangeCore
{
	[PathName("/Script/InterchangeCore.EInterchangeResultType")]
	public enum EInterchangeResultType : long
	{
		Success = 0,
		Warning = 1,
		Error = 2,
	}
}