using Script.CoreUObject;

namespace Script.MetasoundFrontend
{
	[PathName("/Script/MetasoundFrontend.ESetParamResult")]
	public enum ESetParamResult : byte
	{
		Succeeded = 0,
		Failed = 1,
	}
}