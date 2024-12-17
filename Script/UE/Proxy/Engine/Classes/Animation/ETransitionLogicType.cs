using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ETransitionLogicType")]
	public enum ETransitionLogicType : byte
	{
		TLT_StandardBlend = 0,
		TLT_Inertialization = 1,
		TLT_Custom = 2,
	}
}