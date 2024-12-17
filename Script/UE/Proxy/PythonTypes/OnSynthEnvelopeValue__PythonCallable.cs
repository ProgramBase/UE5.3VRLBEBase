using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnSynthEnvelopeValue__PythonCallable.OnSynthEnvelopeValue__PythonCallable")]
	public partial class OnSynthEnvelopeValue__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnSynthEnvelopeValue__PythonCallable.OnSynthEnvelopeValue__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}