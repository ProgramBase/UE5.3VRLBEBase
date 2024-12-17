using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EBlueprintCompileMode")]
	public enum EBlueprintCompileMode : byte
	{
		Default = 0,
		Development = 1,
		FinalRelease = 2,
	}
}