using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraStackEmitterSummaryGroup")]
	public partial class UNiagaraStackEmitterSummaryGroup : UNiagaraStackItemGroup, IStaticClass
	{
		public UNiagaraStackEmitterSummaryItem SummaryItem
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SummaryItem, __ReturnBuffer);

					return *(UNiagaraStackEmitterSummaryItem*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SummaryItem, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraStackEmitterSummaryGroup");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __SummaryItem = 0;
	}
}