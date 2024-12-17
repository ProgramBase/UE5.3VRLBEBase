using Script.CoreUObject;

namespace Script.AnimGraph
{
	[PathName("/Script/AnimGraph.EAnimStateType")]
	public enum EAnimStateType : byte
	{
		AST_SingleAnimation = 0,
		AST_BlendGraph = 1,
	}
}