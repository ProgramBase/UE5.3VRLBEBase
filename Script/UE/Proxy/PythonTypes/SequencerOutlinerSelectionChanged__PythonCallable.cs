using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/SequencerOutlinerSelectionChanged__PythonCallable.SequencerOutlinerSelectionChanged__PythonCallable")]
	public partial class SequencerOutlinerSelectionChanged__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/SequencerOutlinerSelectionChanged__PythonCallable.SequencerOutlinerSelectionChanged__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}