using Script.CoreUObject;

namespace Script.PythonScriptPlugin
{
	[PathName("/Script/PythonScriptPlugin.EPythonCommandFlags")]
	public enum EPythonCommandFlags : long
	{
		None = 0,
		Unattended = 1,
	}
}