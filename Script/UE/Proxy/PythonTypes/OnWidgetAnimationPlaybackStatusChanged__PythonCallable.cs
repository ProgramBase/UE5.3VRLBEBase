using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnWidgetAnimationPlaybackStatusChanged__PythonCallable.OnWidgetAnimationPlaybackStatusChanged__PythonCallable")]
	public partial class OnWidgetAnimationPlaybackStatusChanged__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnWidgetAnimationPlaybackStatusChanged__PythonCallable.OnWidgetAnimationPlaybackStatusChanged__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}