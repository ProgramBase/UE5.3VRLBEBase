using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraSystemVisibilityCullingSettings")]
	public partial class FNiagaraSystemVisibilityCullingSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraSystemVisibilityCullingSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraSystemVisibilityCullingSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraSystemVisibilityCullingSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraSystemVisibilityCullingSettings A, FNiagaraSystemVisibilityCullingSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraSystemVisibilityCullingSettings A, FNiagaraSystemVisibilityCullingSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraSystemVisibilityCullingSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bCullWhenNotRendered
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bCullWhenNotRendered, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bCullWhenNotRendered, __InBuffer);
				}
			}
		}

		public bool bCullByViewFrustum
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bCullByViewFrustum, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bCullByViewFrustum, __InBuffer);
				}
			}
		}

		public bool bAllowPreCullingByViewFrustum
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bAllowPreCullingByViewFrustum, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bAllowPreCullingByViewFrustum, __InBuffer);
				}
			}
		}

		public float MaxTimeOutsideViewFrustum
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MaxTimeOutsideViewFrustum, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MaxTimeOutsideViewFrustum, __InBuffer);
				}
			}
		}

		public float MaxTimeWithoutRender
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MaxTimeWithoutRender, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MaxTimeWithoutRender, __InBuffer);
				}
			}
		}

		private static uint __bCullWhenNotRendered = 0;

		private static uint __bCullByViewFrustum = 0;

		private static uint __bAllowPreCullingByViewFrustum = 0;

		private static uint __MaxTimeOutsideViewFrustum = 0;

		private static uint __MaxTimeWithoutRender = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}