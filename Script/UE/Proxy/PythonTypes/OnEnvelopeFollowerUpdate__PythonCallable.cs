using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnEnvelopeFollowerUpdate__PythonCallable.OnEnvelopeFollowerUpdate__PythonCallable")]
	public partial class OnEnvelopeFollowerUpdate__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnEnvelopeFollowerUpdate__PythonCallable.OnEnvelopeFollowerUpdate__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}