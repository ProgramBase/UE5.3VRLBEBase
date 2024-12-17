using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraStackItemGroup")]
	public partial class UNiagaraStackItemGroup : UNiagaraStackEntry, IStaticClass
	{
		public UNiagaraStackItemGroupFooter GroupFooter
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GroupFooter, __ReturnBuffer);

					return *(UNiagaraStackItemGroupFooter*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GroupFooter, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraStackItemGroup");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __GroupFooter = 0;
	}
}