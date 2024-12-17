using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ETextureCompressionQuality")]
	public enum ETextureCompressionQuality : byte
	{
		TCQ_Default = 0,
		TCQ_Lowest = 1,
		TCQ_Low = 2,
		TCQ_Medium = 3,
		TCQ_High = 4,
		TCQ_Highest = 5,
	}
}