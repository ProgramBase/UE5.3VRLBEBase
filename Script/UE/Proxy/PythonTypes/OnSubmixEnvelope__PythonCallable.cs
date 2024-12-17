using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnSubmixEnvelope__PythonCallable.OnSubmixEnvelope__PythonCallable")]
	public partial class OnSubmixEnvelope__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnSubmixEnvelope__PythonCallable.OnSubmixEnvelope__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}