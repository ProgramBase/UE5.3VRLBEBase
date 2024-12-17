using Script.CoreUObject;

namespace Script.GLTFExporter
{
	[PathName("/Script/GLTFExporter.EGLTFTextureImageFormat")]
	public enum EGLTFTextureImageFormat : byte
	{
		None = 0,
		PNG = 1,
		JPEG = 2,
	}
}