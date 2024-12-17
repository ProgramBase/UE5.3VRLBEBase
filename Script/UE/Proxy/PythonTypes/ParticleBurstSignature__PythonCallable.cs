using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/ParticleBurstSignature__PythonCallable.ParticleBurstSignature__PythonCallable")]
	public partial class ParticleBurstSignature__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/ParticleBurstSignature__PythonCallable.ParticleBurstSignature__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}