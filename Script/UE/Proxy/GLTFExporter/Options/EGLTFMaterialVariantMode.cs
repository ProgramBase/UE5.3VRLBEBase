using Script.CoreUObject;

namespace Script.GLTFExporter
{
	[PathName("/Script/GLTFExporter.EGLTFMaterialVariantMode")]
	public enum EGLTFMaterialVariantMode : byte
	{
		None = 0,
		Simple = 1,
		UseMeshData = 2,
	}
}