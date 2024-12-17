using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EBlueprintType")]
	public enum EBlueprintType : byte
	{
		BPTYPE_Normal = 0,
		BPTYPE_Const = 1,
		BPTYPE_MacroLibrary = 2,
		BPTYPE_Interface = 3,
		BPTYPE_LevelScript = 4,
		BPTYPE_FunctionLibrary = 5,
	}
}