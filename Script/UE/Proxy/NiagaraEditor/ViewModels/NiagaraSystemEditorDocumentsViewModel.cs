using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraSystemEditorDocumentsViewModel")]
	public partial class UNiagaraSystemEditorDocumentsViewModel : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraSystemEditorDocumentsViewModel");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}