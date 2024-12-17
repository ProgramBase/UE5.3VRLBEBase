using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/InterpToMovementComponent_OnInterpToWaitBeginDelegate__PythonCallable.InterpToMovementComponent_OnInterpToWaitBeginDelegate__PythonCallable")]
	public partial class InterpToMovementComponent_OnInterpToWaitBeginDelegate__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/InterpToMovementComponent_OnInterpToWaitBeginDelegate__PythonCallable.InterpToMovementComponent_OnInterpToWaitBeginDelegate__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}