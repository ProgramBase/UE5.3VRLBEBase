using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraParameterBindingWithValue")]
	public partial class FNiagaraParameterBindingWithValue : FNiagaraParameterBinding, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraParameterBindingWithValue");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraParameterBindingWithValue()
		{
		}

		public static bool operator ==(FNiagaraParameterBindingWithValue A, FNiagaraParameterBindingWithValue B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraParameterBindingWithValue A, FNiagaraParameterBindingWithValue B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraParameterBindingWithValue;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<byte> DefaultValue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DefaultValue, __ReturnBuffer);

					return *(TArray<byte>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DefaultValue, __InBuffer);
				}
			}
		}

		private static uint __DefaultValue = 0;

	}
}