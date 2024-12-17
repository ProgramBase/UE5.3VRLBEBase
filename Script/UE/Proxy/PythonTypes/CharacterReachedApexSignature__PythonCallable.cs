using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/CharacterReachedApexSignature__PythonCallable.CharacterReachedApexSignature__PythonCallable")]
	public partial class CharacterReachedApexSignature__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/CharacterReachedApexSignature__PythonCallable.CharacterReachedApexSignature__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}