using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraSimCacheSystemFrame")]
	public partial class FNiagaraSimCacheSystemFrame : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraSimCacheSystemFrame");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraSimCacheSystemFrame() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraSimCacheSystemFrame() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraSimCacheSystemFrame A, FNiagaraSimCacheSystemFrame B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraSimCacheSystemFrame A, FNiagaraSimCacheSystemFrame B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraSimCacheSystemFrame;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FBox LocalBounds
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LocalBounds, __ReturnBuffer);

					return *(FBox*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LocalBounds, __InBuffer);
				}
			}
		}

		public FNiagaraSimCacheDataBuffers SystemDataBuffers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SystemDataBuffers, __ReturnBuffer);

					return *(FNiagaraSimCacheDataBuffers*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SystemDataBuffers, __InBuffer);
				}
			}
		}

		private static uint __LocalBounds = 0;

		private static uint __SystemDataBuffers = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}