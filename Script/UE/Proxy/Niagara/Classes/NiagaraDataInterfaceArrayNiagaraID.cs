using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraDataInterfaceArrayNiagaraID")]
	public partial class UNiagaraDataInterfaceArrayNiagaraID : UNiagaraDataInterfaceArray, IStaticClass
	{
		public TArray<FNiagaraID> IntData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __IntData, __ReturnBuffer);

					return *(TArray<FNiagaraID>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __IntData, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Niagara.NiagaraDataInterfaceArrayNiagaraID");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __IntData = 0;
	}
}