using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/ParticleCollisionSignature__PythonCallable.ParticleCollisionSignature__PythonCallable")]
	public partial class ParticleCollisionSignature__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/ParticleCollisionSignature__PythonCallable.ParticleCollisionSignature__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}