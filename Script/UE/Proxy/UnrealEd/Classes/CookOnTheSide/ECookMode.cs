using Script.CoreUObject;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ECookMode")]
	public enum ECookMode : long
	{
		CookOnTheFly = 0,
		CookOnTheFlyFromTheEditor = 1,
		CookByTheBookFromTheEditor = 2,
		CookByTheBook = 3,
		CookWorker = 4,
	}
}