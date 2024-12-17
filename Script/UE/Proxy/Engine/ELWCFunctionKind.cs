using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ELWCFunctionKind")]
	public enum ELWCFunctionKind : long
	{
		Constructor = 0,
		Promote = 1,
		Demote = 2,
		Add = 3,
		Subtract = 4,
		Divide = 5,
		MultiplyVectorVector = 6,
		MultiplyVectorMatrix = 7,
		MultiplyMatrixMatrix = 8,
		Other = 9,
		Max = 10,
	}
}