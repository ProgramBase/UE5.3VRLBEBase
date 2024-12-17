using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EImportanceWeight")]
	public enum EImportanceWeight : byte
	{
		Luminance = 0,
		Red = 1,
		Green = 2,
		Blue = 3,
		Alpha = 4,
	}
}