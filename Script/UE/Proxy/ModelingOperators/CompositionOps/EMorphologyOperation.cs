using Script.CoreUObject;

namespace Script.ModelingOperators
{
	[PathName("/Script/ModelingOperators.EMorphologyOperation")]
	public enum EMorphologyOperation : byte
	{
		Dilate = 0,
		Contract = 1,
		Close = 2,
		Open = 3,
	}
}