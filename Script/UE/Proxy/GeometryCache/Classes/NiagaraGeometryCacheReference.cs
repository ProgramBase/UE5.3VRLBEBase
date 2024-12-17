using Script.CoreUObject;
using Script.Library;
using Script.Niagara;
using Script.Engine;

namespace Script.GeometryCache
{
	[PathName("/Script/GeometryCache.NiagaraGeometryCacheReference")]
	public partial class FNiagaraGeometryCacheReference : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GeometryCache.NiagaraGeometryCacheReference");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraGeometryCacheReference() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraGeometryCacheReference() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraGeometryCacheReference A, FNiagaraGeometryCacheReference B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraGeometryCacheReference A, FNiagaraGeometryCacheReference B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraGeometryCacheReference;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UGeometryCache GeometryCache
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __GeometryCache, __ReturnBuffer);

					return *(UGeometryCache*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __GeometryCache, __InBuffer);
				}
			}
		}

		public FNiagaraUserParameterBinding GeometryCacheUserParamBinding
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __GeometryCacheUserParamBinding, __ReturnBuffer);

					return *(FNiagaraUserParameterBinding*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __GeometryCacheUserParamBinding, __InBuffer);
				}
			}
		}

		public TArray<UMaterialInterface> OverrideMaterials
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __OverrideMaterials, __ReturnBuffer);

					return *(TArray<UMaterialInterface>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __OverrideMaterials, __InBuffer);
				}
			}
		}

		public TArray<FNiagaraGeometryCacheMICOverride> MICOverrideMaterials
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MICOverrideMaterials, __ReturnBuffer);

					return *(TArray<FNiagaraGeometryCacheMICOverride>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MICOverrideMaterials, __InBuffer);
				}
			}
		}

		private static uint __GeometryCache = 0;

		private static uint __GeometryCacheUserParamBinding = 0;

		private static uint __OverrideMaterials = 0;

		private static uint __MICOverrideMaterials = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}