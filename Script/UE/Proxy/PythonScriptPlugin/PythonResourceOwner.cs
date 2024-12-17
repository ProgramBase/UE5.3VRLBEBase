using Script.CoreUObject;
using Script.Library;

namespace Script.PythonScriptPlugin
{
	[PathName("/Script/PythonScriptPlugin.PythonResourceOwner")]
	public partial class UPythonResourceOwner : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/PythonScriptPlugin.PythonResourceOwner");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/PythonScriptPlugin.PythonResourceOwner")]
	public interface IPythonResourceOwner : IInterface
	{
	}
}