using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ETextureLossyCompressionAmount")]
	public enum ETextureLossyCompressionAmount : byte
	{
		TLCA_Default = 0,
		TLCA_None = 1,
		TLCA_Lowest = 2,
		TLCA_Low = 3,
		TLCA_Medium = 4,
		TLCA_High = 5,
		TLCA_Highest = 6,
	}
}