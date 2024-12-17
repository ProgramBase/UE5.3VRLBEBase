using Script.CoreUObject;

namespace Script.PythonScriptPlugin
{
	[PathName("/Script/PythonScriptPlugin.ETypeHintingMode")]
	public enum ETypeHintingMode : byte
	{
		Off = 0,
		AutoCompletion = 1,
		TypeChecker = 2,
	}
}