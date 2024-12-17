using Script.CoreUObject;
using Script.Niagara;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraEditorParametersAdapter")]
	public partial class UNiagaraEditorParametersAdapter : UNiagaraEditorParametersAdapterBase, IStaticClass
	{
		public TArray<UNiagaraScriptVariable> EditorOnlyScriptVars
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EditorOnlyScriptVars, __ReturnBuffer);

					return *(TArray<UNiagaraScriptVariable>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EditorOnlyScriptVars, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraEditorParametersAdapter");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __EditorOnlyScriptVars = 0;
	}
}