using Script.CoreUObject;

namespace Script.PythonScriptPlugin
{
	[PathName("/Script/PythonScriptPlugin.EPythonCommandExecutionMode")]
	public enum EPythonCommandExecutionMode : byte
	{
		ExecuteFile = 0,
		ExecuteStatement = 1,
		EvaluateStatement = 2,
	}
}