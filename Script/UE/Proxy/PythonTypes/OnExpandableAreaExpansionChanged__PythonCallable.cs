using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnExpandableAreaExpansionChanged__PythonCallable.OnExpandableAreaExpansionChanged__PythonCallable")]
	public partial class OnExpandableAreaExpansionChanged__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnExpandableAreaExpansionChanged__PythonCallable.OnExpandableAreaExpansionChanged__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}