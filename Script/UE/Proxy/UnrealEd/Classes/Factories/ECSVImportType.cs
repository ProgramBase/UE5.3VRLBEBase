using Script.CoreUObject;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ECSVImportType")]
	public enum ECSVImportType : byte
	{
		ECSV_DataTable = 0,
		ECSV_CurveTable = 1,
		ECSV_CurveFloat = 2,
		ECSV_CurveVector = 3,
		ECSV_CurveLinearColor = 4,
	}
}