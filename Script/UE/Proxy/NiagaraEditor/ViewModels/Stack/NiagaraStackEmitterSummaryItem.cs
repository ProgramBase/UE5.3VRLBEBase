using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraStackEmitterSummaryItem")]
	public partial class UNiagaraStackEmitterSummaryItem : UNiagaraStackItem, IStaticClass
	{
		public UNiagaraStackSummaryViewCollection SummaryViewCollection
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SummaryViewCollection, __ReturnBuffer);

					return *(UNiagaraStackSummaryViewCollection*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SummaryViewCollection, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraStackEmitterSummaryItem");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __SummaryViewCollection = 0;
	}
}