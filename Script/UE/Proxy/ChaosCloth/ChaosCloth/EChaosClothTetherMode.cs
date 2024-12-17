using Script.CoreUObject;

namespace Script.ChaosCloth
{
	[PathName("/Script/ChaosCloth.EChaosClothTetherMode")]
	public enum EChaosClothTetherMode : long
	{
		FastTetherFastLength = 0,
		AccurateTetherFastLength = 1,
		AccurateTetherAccurateLength = 2,
		MaxChaosClothTetherMode = 3,
	}
}