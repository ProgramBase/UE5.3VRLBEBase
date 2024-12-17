using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/SourceControl_QueryFileStateDelegate__PythonCallable.SourceControl_QueryFileStateDelegate__PythonCallable")]
	public partial class SourceControl_QueryFileStateDelegate__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/SourceControl_QueryFileStateDelegate__PythonCallable.SourceControl_QueryFileStateDelegate__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}