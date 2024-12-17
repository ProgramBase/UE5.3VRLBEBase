using Script.CoreUObject;
using Script.Library;

namespace Script.PythonScriptPlugin
{
	[PathName("/Script/PythonScriptPlugin.PyTestOtherInterface")]
	public partial class UPyTestOtherInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/PythonScriptPlugin.PyTestOtherInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/PythonScriptPlugin.PyTestOtherInterface")]
	public interface IPyTestOtherInterface : IInterface
	{
		 int FuncInterfaceOther(int InValue);
	}
}