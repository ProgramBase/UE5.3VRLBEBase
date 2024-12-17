using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EGraphType")]
	public enum EGraphType : byte
	{
		GT_Function = 0,
		GT_Ubergraph = 1,
		GT_Macro = 2,
		GT_Animation = 3,
		GT_StateMachine = 4,
	}
}