using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraParameters")]
	public partial class FNiagaraParameters : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraParameters");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraParameters() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraParameters() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraParameters A, FNiagaraParameters B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraParameters A, FNiagaraParameters B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraParameters;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FNiagaraVariable> Parameters
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Parameters, __ReturnBuffer);

					return *(TArray<FNiagaraVariable>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Parameters, __InBuffer);
				}
			}
		}

		private static uint __Parameters = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}