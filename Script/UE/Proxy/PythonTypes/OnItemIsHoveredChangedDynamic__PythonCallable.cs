using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnItemIsHoveredChangedDynamic__PythonCallable.OnItemIsHoveredChangedDynamic__PythonCallable")]
	public partial class OnItemIsHoveredChangedDynamic__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnItemIsHoveredChangedDynamic__PythonCallable.OnItemIsHoveredChangedDynamic__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}