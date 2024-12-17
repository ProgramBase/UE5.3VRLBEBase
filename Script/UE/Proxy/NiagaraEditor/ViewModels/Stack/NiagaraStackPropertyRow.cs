using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraStackPropertyRow")]
	public partial class UNiagaraStackPropertyRow : UNiagaraStackItemContent, IStaticClass
	{
		public UNiagaraStackSpacer CategorySpacer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CategorySpacer, __ReturnBuffer);

					return *(UNiagaraStackSpacer*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CategorySpacer, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraStackPropertyRow");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __CategorySpacer = 0;
	}
}