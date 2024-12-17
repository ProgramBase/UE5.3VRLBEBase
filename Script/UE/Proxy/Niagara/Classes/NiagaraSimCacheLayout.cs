using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraSimCacheLayout")]
	public partial class FNiagaraSimCacheLayout : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraSimCacheLayout");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraSimCacheLayout() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraSimCacheLayout() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraSimCacheLayout A, FNiagaraSimCacheLayout B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraSimCacheLayout A, FNiagaraSimCacheLayout B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraSimCacheLayout;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FNiagaraSimCacheDataBuffersLayout SystemLayout
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SystemLayout, __ReturnBuffer);

					return *(FNiagaraSimCacheDataBuffersLayout*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SystemLayout, __InBuffer);
				}
			}
		}

		public TArray<FNiagaraSimCacheDataBuffersLayout> EmitterLayouts
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EmitterLayouts, __ReturnBuffer);

					return *(TArray<FNiagaraSimCacheDataBuffersLayout>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EmitterLayouts, __InBuffer);
				}
			}
		}

		private static uint __SystemLayout = 0;

		private static uint __EmitterLayouts = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}