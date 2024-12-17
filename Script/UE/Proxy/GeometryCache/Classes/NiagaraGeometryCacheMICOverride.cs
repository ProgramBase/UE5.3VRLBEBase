using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.GeometryCache
{
	[PathName("/Script/GeometryCache.NiagaraGeometryCacheMICOverride")]
	public partial class FNiagaraGeometryCacheMICOverride : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GeometryCache.NiagaraGeometryCacheMICOverride");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraGeometryCacheMICOverride() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraGeometryCacheMICOverride() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraGeometryCacheMICOverride A, FNiagaraGeometryCacheMICOverride B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraGeometryCacheMICOverride A, FNiagaraGeometryCacheMICOverride B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraGeometryCacheMICOverride;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UMaterialInterface OriginalMaterial
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __OriginalMaterial, __ReturnBuffer);

					return *(UMaterialInterface*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __OriginalMaterial, __InBuffer);
				}
			}
		}

		public UMaterialInstanceConstant ReplacementMaterial
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ReplacementMaterial, __ReturnBuffer);

					return *(UMaterialInstanceConstant*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ReplacementMaterial, __InBuffer);
				}
			}
		}

		private static uint __OriginalMaterial = 0;

		private static uint __ReplacementMaterial = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}