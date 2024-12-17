using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/InterpToMovementComponent_OnInterpToReverseDelegate__PythonCallable.InterpToMovementComponent_OnInterpToReverseDelegate__PythonCallable")]
	public partial class InterpToMovementComponent_OnInterpToReverseDelegate__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/InterpToMovementComponent_OnInterpToReverseDelegate__PythonCallable.InterpToMovementComponent_OnInterpToReverseDelegate__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}