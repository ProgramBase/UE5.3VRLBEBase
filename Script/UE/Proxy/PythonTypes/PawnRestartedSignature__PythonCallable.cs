using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/PawnRestartedSignature__PythonCallable.PawnRestartedSignature__PythonCallable")]
	public partial class PawnRestartedSignature__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/PawnRestartedSignature__PythonCallable.PawnRestartedSignature__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}