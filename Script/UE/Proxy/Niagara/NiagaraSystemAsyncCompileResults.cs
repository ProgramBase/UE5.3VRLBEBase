using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraSystemAsyncCompileResults")]
	public partial class FNiagaraSystemAsyncCompileResults : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraSystemAsyncCompileResults");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraSystemAsyncCompileResults() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraSystemAsyncCompileResults() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraSystemAsyncCompileResults A, FNiagaraSystemAsyncCompileResults B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraSystemAsyncCompileResults A, FNiagaraSystemAsyncCompileResults B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraSystemAsyncCompileResults;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<UObject> RootObjects
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RootObjects, __ReturnBuffer);

					return *(TArray<UObject>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RootObjects, __InBuffer);
				}
			}
		}

		public TArray<FNiagaraVariable> ExposedVariables
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ExposedVariables, __ReturnBuffer);

					return *(TArray<FNiagaraVariable>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ExposedVariables, __InBuffer);
				}
			}
		}

		private static uint __RootObjects = 0;

		private static uint __ExposedVariables = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}