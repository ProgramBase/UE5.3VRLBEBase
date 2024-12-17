using Script.CoreUObject;

namespace Script.FractureEditor
{
	[PathName("/Script/FractureEditor.EDownsamplingMode")]
	public enum EDownsamplingMode : int
	{
		Random = 0,
		UniformSpacing = 1,
		KeepSharp = 2,
	}
}