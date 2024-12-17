using Script.CoreUObject;

namespace Script.SpeedTreeImporter
{
	[PathName("/Script/SpeedTreeImporter.EImportLODType")]
	public enum EImportLODType : byte
	{
		ILT_PaintedFoliage = 0,
		ILT_IndividualActors = 1,
	}
}