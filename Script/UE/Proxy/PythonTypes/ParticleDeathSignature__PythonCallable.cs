using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/ParticleDeathSignature__PythonCallable.ParticleDeathSignature__PythonCallable")]
	public partial class ParticleDeathSignature__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/ParticleDeathSignature__PythonCallable.ParticleDeathSignature__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}