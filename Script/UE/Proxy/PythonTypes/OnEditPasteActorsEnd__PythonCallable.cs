using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnEditPasteActorsEnd__PythonCallable.OnEditPasteActorsEnd__PythonCallable")]
	public partial class OnEditPasteActorsEnd__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnEditPasteActorsEnd__PythonCallable.OnEditPasteActorsEnd__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}