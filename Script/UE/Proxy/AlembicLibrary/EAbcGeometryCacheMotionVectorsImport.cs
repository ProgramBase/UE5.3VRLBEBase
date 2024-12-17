using Script.CoreUObject;

namespace Script.AlembicLibrary
{
	[PathName("/Script/AlembicLibrary.EAbcGeometryCacheMotionVectorsImport")]
	public enum EAbcGeometryCacheMotionVectorsImport : byte
	{
		NoMotionVectors = 0,
		ImportAbcVelocitiesAsMotionVectors = 1,
		CalculateMotionVectorsDuringImport = 2,
	}
}