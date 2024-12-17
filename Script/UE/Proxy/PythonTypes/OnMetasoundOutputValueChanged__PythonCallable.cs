using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnMetasoundOutputValueChanged__PythonCallable.OnMetasoundOutputValueChanged__PythonCallable")]
	public partial class OnMetasoundOutputValueChanged__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnMetasoundOutputValueChanged__PythonCallable.OnMetasoundOutputValueChanged__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}