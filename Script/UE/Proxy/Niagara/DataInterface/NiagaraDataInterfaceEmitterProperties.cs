using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraDataInterfaceEmitterProperties")]
	public partial class UNiagaraDataInterfaceEmitterProperties : UNiagaraDataInterface, IStaticClass
	{
		public FNiagaraDataInterfaceEmitterBinding EmitterBinding
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EmitterBinding, __ReturnBuffer);

					return *(FNiagaraDataInterfaceEmitterBinding*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EmitterBinding, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Niagara.NiagaraDataInterfaceEmitterProperties");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __EmitterBinding = 0;
	}
}