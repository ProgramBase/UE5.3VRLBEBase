using Script.CoreUObject;

namespace Script.ChaosNiagara
{
	[PathName("/Script/ChaosNiagara.EDataSortTypeEnum")]
	public enum EDataSortTypeEnum : byte
	{
		ChaosNiagara_DataSortType_NoSorting = 0,
		ChaosNiagara_DataSortType_RandomShuffle = 1,
		ChaosNiagara_DataSortType_SortByMassMaxToMin = 2,
		ChaosNiagara_DataSortType_SortByMassMinToMax = 3,
		ChaosNiagara_Max = 4,
	}
}