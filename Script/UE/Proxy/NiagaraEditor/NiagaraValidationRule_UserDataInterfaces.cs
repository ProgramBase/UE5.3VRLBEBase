using Script.CoreUObject;
using Script.Niagara;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraValidationRule_UserDataInterfaces")]
	public partial class UNiagaraValidationRule_UserDataInterfaces : UNiagaraValidationRule, IStaticClass
	{
		public bool bOnlyIncludeExposedUObjects
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bOnlyIncludeExposedUObjects, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bOnlyIncludeExposedUObjects, __InBuffer);
				}
			}
		}

		public TArray<TSubclassOf<UNiagaraDataInterface>> BannedDataInterfaces
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BannedDataInterfaces, __ReturnBuffer);

					return *(TArray<TSubclassOf<UNiagaraDataInterface>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BannedDataInterfaces, __InBuffer);
				}
			}
		}

		public TArray<TSubclassOf<UNiagaraDataInterface>> AllowDataInterfaces
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AllowDataInterfaces, __ReturnBuffer);

					return *(TArray<TSubclassOf<UNiagaraDataInterface>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AllowDataInterfaces, __InBuffer);
				}
			}
		}

		public ENiagaraValidationSeverity Severity
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Severity, __ReturnBuffer);

					return *(ENiagaraValidationSeverity*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = (int)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Severity, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraValidationRule_UserDataInterfaces");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __bOnlyIncludeExposedUObjects = 0;

		private static uint __BannedDataInterfaces = 0;

		private static uint __AllowDataInterfaces = 0;

		private static uint __Severity = 0;
	}
}