using Script.CoreUObject;

namespace Script.ModelingOperators
{
	[PathName("/Script/ModelingOperators.EUVLayoutType")]
	public enum EUVLayoutType : int
	{
		Transform = 0,
		Stack = 1,
		Repack = 2,
		Normalize = 3,
	}
}