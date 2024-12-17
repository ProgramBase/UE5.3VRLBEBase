using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.TextureFilter")]
	public enum TextureFilter : byte
	{
		TF_Nearest = 0,
		TF_Bilinear = 1,
		TF_Trilinear = 2,
		TF_Default = 3,
	}
}