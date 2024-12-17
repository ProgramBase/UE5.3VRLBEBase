using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/ConstraintBrokenSignature__PythonCallable.ConstraintBrokenSignature__PythonCallable")]
	public partial class ConstraintBrokenSignature__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/ConstraintBrokenSignature__PythonCallable.ConstraintBrokenSignature__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}