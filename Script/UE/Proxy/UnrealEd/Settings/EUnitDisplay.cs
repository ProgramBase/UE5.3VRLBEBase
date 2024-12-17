using Script.CoreUObject;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.EUnitDisplay")]
	public enum EUnitDisplay : long
	{
		None = 0,
		Metric = 1,
		Imperial = 2,
		Invalid = 3,
	}
}