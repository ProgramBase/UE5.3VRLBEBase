using Script.CoreUObject;
using Script.Library;
using Script.NiagaraCore;

namespace Script.NiagaraShader
{
	[PathName("/Script/NiagaraShader.NiagaraDataInterfaceGeneratedFunction")]
	public partial class FNiagaraDataInterfaceGeneratedFunction : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/NiagaraShader.NiagaraDataInterfaceGeneratedFunction");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraDataInterfaceGeneratedFunction() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraDataInterfaceGeneratedFunction() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraDataInterfaceGeneratedFunction A, FNiagaraDataInterfaceGeneratedFunction B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraDataInterfaceGeneratedFunction A, FNiagaraDataInterfaceGeneratedFunction B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraDataInterfaceGeneratedFunction;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FNiagaraVariableCommonReference> VariadicInputs
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __VariadicInputs, __ReturnBuffer);

					return *(TArray<FNiagaraVariableCommonReference>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __VariadicInputs, __InBuffer);
				}
			}
		}

		public TArray<FNiagaraVariableCommonReference> VariadicOutputs
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __VariadicOutputs, __ReturnBuffer);

					return *(TArray<FNiagaraVariableCommonReference>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __VariadicOutputs, __InBuffer);
				}
			}
		}

		private static uint __VariadicInputs = 0;

		private static uint __VariadicOutputs = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}