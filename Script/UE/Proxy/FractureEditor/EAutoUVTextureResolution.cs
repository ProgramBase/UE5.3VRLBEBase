using Script.CoreUObject;

namespace Script.FractureEditor
{
	[PathName("/Script/FractureEditor.EAutoUVTextureResolution")]
	public enum EAutoUVTextureResolution : int
	{
		Resolution16 = 16,
		Resolution32 = 32,
		Resolution64 = 64,
		Resolution128 = 128,
		Resolution256 = 256,
		Resolution512 = 512,
		Resolution1024 = 1024,
		Resolution2048 = 2048,
		Resolution4096 = 4096,
		Resolution8192 = 8192,
	}
}