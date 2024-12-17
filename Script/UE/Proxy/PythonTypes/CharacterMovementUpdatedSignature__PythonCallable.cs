using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/CharacterMovementUpdatedSignature__PythonCallable.CharacterMovementUpdatedSignature__PythonCallable")]
	public partial class CharacterMovementUpdatedSignature__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/CharacterMovementUpdatedSignature__PythonCallable.CharacterMovementUpdatedSignature__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}