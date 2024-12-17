using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENiagaraRibbonUVDistributionMode")]
	public enum ENiagaraRibbonUVDistributionMode : byte
	{
		ScaledUniformly = 0,
		ScaledUsingRibbonSegmentLength = 1,
		TiledOverRibbonLength = 2,
		TiledFromStartOverRibbonLength = 3,
	}
}