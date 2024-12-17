using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraCore
{
	[PathName("/Script/NiagaraCore.NiagaraCompileHash")]
	public partial class FNiagaraCompileHash : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/NiagaraCore.NiagaraCompileHash");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraCompileHash() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraCompileHash() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraCompileHash A, FNiagaraCompileHash B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraCompileHash A, FNiagaraCompileHash B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraCompileHash;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<byte> DataHash
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DataHash, __ReturnBuffer);

					return *(TArray<byte>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DataHash, __InBuffer);
				}
			}
		}

		private static uint __DataHash = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}