using Script.CoreUObject;
using Script.Library;

namespace Script.PythonScriptPlugin
{
	[PathName("/Script/PythonScriptPlugin.PyTestChildInterface")]
	public partial class UPyTestChildInterface : UPyTestInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/PythonScriptPlugin.PyTestChildInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/PythonScriptPlugin.PyTestChildInterface")]
	public interface IPyTestChildInterface : IPyTestInterface
	{
		 int FuncInterfaceChild(int InValue);
	}
}