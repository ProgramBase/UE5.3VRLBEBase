using Script.CoreUObject;
using Script.Library;

namespace Script.PythonScriptPlugin
{
	[PathName("/Script/PythonScriptPlugin.PyTestInterface")]
	public partial class UPyTestInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/PythonScriptPlugin.PyTestInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/PythonScriptPlugin.PyTestInterface")]
	public interface IPyTestInterface : IInterface
	{
		 int FuncInterface(int InValue);
	}
}