using Script.CoreUObject;

namespace Script.WindowsTargetPlatform
{
	[PathName("/Script/WindowsTargetPlatform.ECompilerVersion")]
	public enum ECompilerVersion : byte
	{
		Default = 0,
		VisualStudio2015 = 1,
		VisualStudio2017 = 2,
		VisualStudio2019 = 3,
		VisualStudio2022 = 4,
	}
}