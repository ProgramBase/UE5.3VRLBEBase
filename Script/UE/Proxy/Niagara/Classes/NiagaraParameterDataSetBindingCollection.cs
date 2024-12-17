using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraParameterDataSetBindingCollection")]
	public partial class FNiagaraParameterDataSetBindingCollection : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraParameterDataSetBindingCollection");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraParameterDataSetBindingCollection() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraParameterDataSetBindingCollection() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraParameterDataSetBindingCollection A, FNiagaraParameterDataSetBindingCollection B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraParameterDataSetBindingCollection A, FNiagaraParameterDataSetBindingCollection B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraParameterDataSetBindingCollection;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FNiagaraParameterDataSetBinding> FloatOffsets
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FloatOffsets, __ReturnBuffer);

					return *(TArray<FNiagaraParameterDataSetBinding>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FloatOffsets, __InBuffer);
				}
			}
		}

		public TArray<FNiagaraParameterDataSetBinding> Int32Offsets
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Int32Offsets, __ReturnBuffer);

					return *(TArray<FNiagaraParameterDataSetBinding>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Int32Offsets, __InBuffer);
				}
			}
		}

		private static uint __FloatOffsets = 0;

		private static uint __Int32Offsets = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}