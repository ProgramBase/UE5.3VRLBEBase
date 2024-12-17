using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/CollisionEventSignature__PythonCallable.CollisionEventSignature__PythonCallable")]
	public partial class CollisionEventSignature__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/CollisionEventSignature__PythonCallable.CollisionEventSignature__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}