using Script.CoreUObject;

namespace Script.GLTFExporter
{
	[PathName("/Script/GLTFExporter.EGLTFMaterialBakeMode")]
	public enum EGLTFMaterialBakeMode : byte
	{
		Disabled = 0,
		Simple = 1,
		UseMeshData = 2,
	}
}