using Script.CoreUObject;

namespace Script.FunctionalTesting
{
	[PathName("/Script/FunctionalTesting.EComparisonTolerance")]
	public enum EComparisonTolerance : byte
	{
		Zero = 0,
		Low = 1,
		Medium = 2,
		High = 3,
		Custom = 4,
	}
}