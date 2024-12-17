using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/PlayMontageAnimNotifyDelegate__PythonCallable.PlayMontageAnimNotifyDelegate__PythonCallable")]
	public partial class PlayMontageAnimNotifyDelegate__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/PlayMontageAnimNotifyDelegate__PythonCallable.PlayMontageAnimNotifyDelegate__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}