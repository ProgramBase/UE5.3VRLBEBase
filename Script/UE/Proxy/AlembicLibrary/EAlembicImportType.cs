using Script.CoreUObject;

namespace Script.AlembicLibrary
{
	[PathName("/Script/AlembicLibrary.EAlembicImportType")]
	public enum EAlembicImportType : byte
	{
		StaticMesh = 0,
		GeometryCache = 1,
		Skeletal = 2,
	}
}