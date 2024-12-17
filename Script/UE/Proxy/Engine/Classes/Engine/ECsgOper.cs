using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ECsgOper")]
	public enum ECsgOper : long
	{
		CSG_Active = 0,
		CSG_Add = 1,
		CSG_Subtract = 2,
		CSG_Intersect = 3,
		CSG_Deintersect = 4,
		CSG_None = 5,
	}
}