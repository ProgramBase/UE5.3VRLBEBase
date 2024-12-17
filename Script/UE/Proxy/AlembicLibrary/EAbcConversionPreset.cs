using Script.CoreUObject;

namespace Script.AlembicLibrary
{
	[PathName("/Script/AlembicLibrary.EAbcConversionPreset")]
	public enum EAbcConversionPreset : byte
	{
		Maya = 0,
		Max = 1,
		Custom = 2,
	}
}