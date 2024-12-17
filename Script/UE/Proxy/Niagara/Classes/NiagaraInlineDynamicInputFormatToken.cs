using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraInlineDynamicInputFormatToken")]
	public partial class FNiagaraInlineDynamicInputFormatToken : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraInlineDynamicInputFormatToken");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraInlineDynamicInputFormatToken() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraInlineDynamicInputFormatToken() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraInlineDynamicInputFormatToken A, FNiagaraInlineDynamicInputFormatToken B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraInlineDynamicInputFormatToken A, FNiagaraInlineDynamicInputFormatToken B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraInlineDynamicInputFormatToken;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public ENiagaraInlineDynamicInputFormatTokenUsage Usage
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Usage, __ReturnBuffer);

					return *(ENiagaraInlineDynamicInputFormatTokenUsage*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = (int)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Usage, __InBuffer);
				}
			}
		}

		public FString Value
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Value, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Value, __InBuffer);
				}
			}
		}

		private static uint __Usage = 0;

		private static uint __Value = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}