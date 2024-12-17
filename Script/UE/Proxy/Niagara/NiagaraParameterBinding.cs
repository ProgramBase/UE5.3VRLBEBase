using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraParameterBinding")]
	public partial class FNiagaraParameterBinding : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraParameterBinding");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraParameterBinding() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraParameterBinding() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraParameterBinding A, FNiagaraParameterBinding B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraParameterBinding A, FNiagaraParameterBinding B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraParameterBinding;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FNiagaraVariableBase ResolvedParameter
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ResolvedParameter, __ReturnBuffer);

					return *(FNiagaraVariableBase*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ResolvedParameter, __InBuffer);
				}
			}
		}

		public FNiagaraVariableBase AliasedParameter
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AliasedParameter, __ReturnBuffer);

					return *(FNiagaraVariableBase*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AliasedParameter, __InBuffer);
				}
			}
		}

		public TArray<TSubclassOf<UObject>> AllowedDataInterfaces
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AllowedDataInterfaces, __ReturnBuffer);

					return *(TArray<TSubclassOf<UObject>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AllowedDataInterfaces, __InBuffer);
				}
			}
		}

		public TArray<TSubclassOf<UObject>> AllowedObjects
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AllowedObjects, __ReturnBuffer);

					return *(TArray<TSubclassOf<UObject>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AllowedObjects, __InBuffer);
				}
			}
		}

		public TArray<TSubclassOf<UObject>> AllowedInterfaces
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AllowedInterfaces, __ReturnBuffer);

					return *(TArray<TSubclassOf<UObject>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AllowedInterfaces, __InBuffer);
				}
			}
		}

		private static uint __ResolvedParameter = 0;

		private static uint __AliasedParameter = 0;

		private static uint __AllowedDataInterfaces = 0;

		private static uint __AllowedObjects = 0;

		private static uint __AllowedInterfaces = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}