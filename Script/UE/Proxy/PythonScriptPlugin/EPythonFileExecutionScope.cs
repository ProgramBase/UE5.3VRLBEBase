using Script.CoreUObject;

namespace Script.PythonScriptPlugin
{
	[PathName("/Script/PythonScriptPlugin.EPythonFileExecutionScope")]
	public enum EPythonFileExecutionScope : byte
	{
		Private = 0,
		Public = 1,
	}
}