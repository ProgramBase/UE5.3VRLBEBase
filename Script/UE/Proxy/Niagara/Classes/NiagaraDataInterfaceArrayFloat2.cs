using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraDataInterfaceArrayFloat2")]
	public partial class UNiagaraDataInterfaceArrayFloat2 : UNiagaraDataInterfaceArray, IStaticClass
	{
		public TArray<FVector2D> FloatData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FloatData, __ReturnBuffer);

					return *(TArray<FVector2D>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FloatData, __InBuffer);
				}
			}
		}

		public TArray<FVector2f> InternalFloatData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InternalFloatData, __ReturnBuffer);

					return *(TArray<FVector2f>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InternalFloatData, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Niagara.NiagaraDataInterfaceArrayFloat2");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __FloatData = 0;

		private static uint __InternalFloatData = 0;
	}
}