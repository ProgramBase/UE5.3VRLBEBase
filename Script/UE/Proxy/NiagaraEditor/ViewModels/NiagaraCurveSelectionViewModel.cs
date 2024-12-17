using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraCurveSelectionViewModel")]
	public partial class UNiagaraCurveSelectionViewModel : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraCurveSelectionViewModel");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}