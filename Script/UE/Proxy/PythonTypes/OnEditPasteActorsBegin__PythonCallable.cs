using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnEditPasteActorsBegin__PythonCallable.OnEditPasteActorsBegin__PythonCallable")]
	public partial class OnEditPasteActorsBegin__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnEditPasteActorsBegin__PythonCallable.OnEditPasteActorsBegin__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}