using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraDataInterfaceArrayMatrix")]
	public partial class UNiagaraDataInterfaceArrayMatrix : UNiagaraDataInterfaceArray, IStaticClass
	{
		public TArray<FMatrix> MatrixData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MatrixData, __ReturnBuffer);

					return *(TArray<FMatrix>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MatrixData, __InBuffer);
				}
			}
		}

		public TArray<FMatrix44f> InternalMatrixData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InternalMatrixData, __ReturnBuffer);

					return *(TArray<FMatrix44f>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InternalMatrixData, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Niagara.NiagaraDataInterfaceArrayMatrix");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __MatrixData = 0;

		private static uint __InternalMatrixData = 0;
	}
}