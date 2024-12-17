using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraDataChannelGameDataLayout")]
	public partial class FNiagaraDataChannelGameDataLayout : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraDataChannelGameDataLayout");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraDataChannelGameDataLayout() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraDataChannelGameDataLayout() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraDataChannelGameDataLayout A, FNiagaraDataChannelGameDataLayout B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraDataChannelGameDataLayout A, FNiagaraDataChannelGameDataLayout B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraDataChannelGameDataLayout;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TMap<FNiagaraVariableBase, int> VariableIndices
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __VariableIndices, __ReturnBuffer);

					return *(TMap<FNiagaraVariableBase, int>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __VariableIndices, __InBuffer);
				}
			}
		}

		public TArray<FNiagaraLwcStructConverter> LwcConverters
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LwcConverters, __ReturnBuffer);

					return *(TArray<FNiagaraLwcStructConverter>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LwcConverters, __InBuffer);
				}
			}
		}

		private static uint __VariableIndices = 0;

		private static uint __LwcConverters = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}