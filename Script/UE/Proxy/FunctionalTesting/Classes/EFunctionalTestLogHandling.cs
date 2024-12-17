using Script.CoreUObject;

namespace Script.FunctionalTesting
{
	[PathName("/Script/FunctionalTesting.EFunctionalTestLogHandling")]
	public enum EFunctionalTestLogHandling : byte
	{
		ProjectDefault = 0,
		OutputIsError = 1,
		OutputIgnored = 2,
	}
}