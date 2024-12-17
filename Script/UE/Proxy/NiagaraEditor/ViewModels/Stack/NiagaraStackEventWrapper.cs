using Script.CoreUObject;
using Script.Library;
using Script.Niagara;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraStackEventWrapper")]
	public partial class UNiagaraStackEventWrapper : UObject, IStaticClass
	{
		public TArray<FNiagaraEventScriptProperties> EventHandlerScriptProps
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EventHandlerScriptProps, __ReturnBuffer);

					return *(TArray<FNiagaraEventScriptProperties>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EventHandlerScriptProps, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraStackEventWrapper");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __EventHandlerScriptProps = 0;
	}
}