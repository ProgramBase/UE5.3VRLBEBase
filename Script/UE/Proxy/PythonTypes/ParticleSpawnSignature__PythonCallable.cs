using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/ParticleSpawnSignature__PythonCallable.ParticleSpawnSignature__PythonCallable")]
	public partial class ParticleSpawnSignature__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/ParticleSpawnSignature__PythonCallable.ParticleSpawnSignature__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}