using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraDataInterfaceSimpleCounter")]
	public partial class UNiagaraDataInterfaceSimpleCounter : UNiagaraDataInterfaceRWBase, IStaticClass
	{
		public ENiagaraGpuSyncMode GpuSyncMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GpuSyncMode, __ReturnBuffer);

					return *(ENiagaraGpuSyncMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = (int)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GpuSyncMode, __InBuffer);
				}
			}
		}

		public int InitialValue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InitialValue, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InitialValue, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Niagara.NiagaraDataInterfaceSimpleCounter");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __GpuSyncMode = 0;

		private static uint __InitialValue = 0;
	}
}