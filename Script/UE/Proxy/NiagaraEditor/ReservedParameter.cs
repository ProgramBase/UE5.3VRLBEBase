using Script.CoreUObject;
using Script.Library;
using Script.Niagara;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.ReservedParameter")]
	public partial class FReservedParameter : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/NiagaraEditor.ReservedParameter");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FReservedParameter() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FReservedParameter() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FReservedParameter A, FReservedParameter B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FReservedParameter A, FReservedParameter B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FReservedParameter;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FNiagaraVariableBase Parameter
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Parameter, __ReturnBuffer);

					return *(FNiagaraVariableBase*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Parameter, __InBuffer);
				}
			}
		}

		public UNiagaraParameterDefinitions ReservingDefinitionsAsset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ReservingDefinitionsAsset, __ReturnBuffer);

					return *(UNiagaraParameterDefinitions*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ReservingDefinitionsAsset, __InBuffer);
				}
			}
		}

		private static uint __Parameter = 0;

		private static uint __ReservingDefinitionsAsset = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}