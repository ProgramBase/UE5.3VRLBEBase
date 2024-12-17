using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnSubmixEnvelopeBP__PythonCallable.OnSubmixEnvelopeBP__PythonCallable")]
	public partial class OnSubmixEnvelopeBP__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnSubmixEnvelopeBP__PythonCallable.OnSubmixEnvelopeBP__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}