using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraVariableWithOffset")]
	public partial class FNiagaraVariableWithOffset : FNiagaraVariableBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraVariableWithOffset");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraVariableWithOffset()
		{
		}

		public static bool operator ==(FNiagaraVariableWithOffset A, FNiagaraVariableWithOffset B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraVariableWithOffset A, FNiagaraVariableWithOffset B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraVariableWithOffset;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int Offset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Offset, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Offset, __InBuffer);
				}
			}
		}

		public FNiagaraLwcStructConverter StructConverter
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __StructConverter, __ReturnBuffer);

					return *(FNiagaraLwcStructConverter*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __StructConverter, __InBuffer);
				}
			}
		}

		private static uint __Offset = 0;

		private static uint __StructConverter = 0;

	}
}