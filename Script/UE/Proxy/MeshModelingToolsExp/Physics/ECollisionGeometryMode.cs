using Script.CoreUObject;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.ECollisionGeometryMode")]
	public enum ECollisionGeometryMode : int
	{
		Default = 0,
		SimpleAndComplex = 1,
		UseSimpleAsComplex = 2,
		UseComplexAsSimple = 3,
	}
}