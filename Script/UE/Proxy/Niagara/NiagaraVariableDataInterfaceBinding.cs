using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraVariableDataInterfaceBinding")]
	public partial class FNiagaraVariableDataInterfaceBinding : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraVariableDataInterfaceBinding");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraVariableDataInterfaceBinding() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraVariableDataInterfaceBinding() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraVariableDataInterfaceBinding A, FNiagaraVariableDataInterfaceBinding B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraVariableDataInterfaceBinding A, FNiagaraVariableDataInterfaceBinding B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraVariableDataInterfaceBinding;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FNiagaraVariable BoundVariable
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BoundVariable, __ReturnBuffer);

					return *(FNiagaraVariable*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BoundVariable, __InBuffer);
				}
			}
		}

		private static uint __BoundVariable = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}