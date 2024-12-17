using Script.CoreUObject;

namespace Script.SpeedTreeImporter
{
	[PathName("/Script/SpeedTreeImporter.EImportGeometryType")]
	public enum EImportGeometryType : byte
	{
		IGT_3D = 0,
		IGT_Billboards = 1,
		IGT_Both = 2,
	}
}