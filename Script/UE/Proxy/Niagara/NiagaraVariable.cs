using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraVariable")]
	public partial class FNiagaraVariable : FNiagaraVariableBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraVariable");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraVariable()
		{
		}

		public static bool operator ==(FNiagaraVariable A, FNiagaraVariable B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraVariable A, FNiagaraVariable B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraVariable;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<byte> VarData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __VarData, __ReturnBuffer);

					return *(TArray<byte>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __VarData, __InBuffer);
				}
			}
		}

		private static uint __VarData = 0;

	}
}