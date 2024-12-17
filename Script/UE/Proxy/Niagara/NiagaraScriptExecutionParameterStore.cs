using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraScriptExecutionParameterStore")]
	public partial class FNiagaraScriptExecutionParameterStore : FNiagaraParameterStore, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraScriptExecutionParameterStore");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraScriptExecutionParameterStore()
		{
		}

		public static bool operator ==(FNiagaraScriptExecutionParameterStore A, FNiagaraScriptExecutionParameterStore B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraScriptExecutionParameterStore A, FNiagaraScriptExecutionParameterStore B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraScriptExecutionParameterStore;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int ParameterSize
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ParameterSize, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ParameterSize, __InBuffer);
				}
			}
		}

		public uint PaddedParameterSize
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PaddedParameterSize, __ReturnBuffer);

					return *(uint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(uint*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PaddedParameterSize, __InBuffer);
				}
			}
		}

		public TArray<FNiagaraScriptExecutionPaddingInfo> PaddingInfo
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PaddingInfo, __ReturnBuffer);

					return *(TArray<FNiagaraScriptExecutionPaddingInfo>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PaddingInfo, __InBuffer);
				}
			}
		}

		public bool bInitialized
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bInitialized, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bInitialized, __InBuffer);
				}
			}
		}

		private static uint __ParameterSize = 0;

		private static uint __PaddedParameterSize = 0;

		private static uint __PaddingInfo = 0;

		private static uint __bInitialized = 0;

	}
}