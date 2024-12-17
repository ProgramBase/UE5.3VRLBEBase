using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EPrimaryAssetCookRule")]
	public enum EPrimaryAssetCookRule : byte
	{
		Unknown = 0,
		NeverCook = 1,
		ProductionNeverCook = 2,
		DevelopmentCook = 2,
		DevelopmentAlwaysProductionNeverCook = 3,
		DevelopmentAlwaysCook = 3,
		DevelopmentAlwaysProductionUnknownCook = 4,
		AlwaysCook = 5,
	}
}