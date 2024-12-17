using Script.CoreUObject;

namespace Script.ModelingOperators
{
	[PathName("/Script/ModelingOperators.EUVProjectionMethod")]
	public enum EUVProjectionMethod : byte
	{
		Box = 0,
		Cylinder = 1,
		Plane = 2,
		ExpMap = 3,
	}
}