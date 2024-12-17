using Script.CoreUObject;

namespace Script.FunctionalTesting
{
	[PathName("/Script/FunctionalTesting.EFunctionalTestResult")]
	public enum EFunctionalTestResult : byte
	{
		Default = 0,
		Invalid = 1,
		Error = 2,
		Running = 3,
		Failed = 4,
		Succeeded = 5,
	}
}