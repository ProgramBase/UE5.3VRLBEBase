using Script.CoreUObject;

namespace Script.ChaosNiagara
{
	[PathName("/Script/ChaosNiagara.EDataSourceTypeEnum")]
	public enum EDataSourceTypeEnum : byte
	{
		ChaosNiagara_DataSourceType_Collision = 0,
		ChaosNiagara_DataSourceType_Breaking = 1,
		ChaosNiagara_DataSourceType_Trailing = 2,
		ChaosNiagara_Max = 3,
	}
}