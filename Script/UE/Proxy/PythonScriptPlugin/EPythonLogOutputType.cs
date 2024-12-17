using Script.CoreUObject;

namespace Script.PythonScriptPlugin
{
	[PathName("/Script/PythonScriptPlugin.EPythonLogOutputType")]
	public enum EPythonLogOutputType : byte
	{
		Info = 0,
		Warning = 1,
		Error = 2,
	}
}