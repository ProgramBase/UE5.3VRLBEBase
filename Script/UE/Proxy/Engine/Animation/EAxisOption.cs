using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EAxisOption")]
	public enum EAxisOption : long
	{
		X = 0,
		Y = 1,
		Z = 2,
		X_Neg = 3,
		Y_Neg = 4,
		Z_Neg = 5,
		Custom = 6,
	}
}