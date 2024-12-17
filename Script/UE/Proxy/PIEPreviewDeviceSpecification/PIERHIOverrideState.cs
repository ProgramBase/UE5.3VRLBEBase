using Script.CoreUObject;
using Script.Library;

namespace Script.PIEPreviewDeviceSpecification
{
	[PathName("/Script/PIEPreviewDeviceSpecification.PIERHIOverrideState")]
	public partial class FPIERHIOverrideState : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/PIEPreviewDeviceSpecification.PIERHIOverrideState");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPIERHIOverrideState() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPIERHIOverrideState() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPIERHIOverrideState A, FPIERHIOverrideState B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPIERHIOverrideState A, FPIERHIOverrideState B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPIERHIOverrideState;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int MaxShadowDepthBufferSizeX
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MaxShadowDepthBufferSizeX, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MaxShadowDepthBufferSizeX, __InBuffer);
				}
			}
		}

		public int MaxShadowDepthBufferSizeY
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MaxShadowDepthBufferSizeY, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MaxShadowDepthBufferSizeY, __InBuffer);
				}
			}
		}

		public int MaxTextureDimensions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MaxTextureDimensions, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MaxTextureDimensions, __InBuffer);
				}
			}
		}

		public int MaxCubeTextureDimensions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MaxCubeTextureDimensions, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MaxCubeTextureDimensions, __InBuffer);
				}
			}
		}

		public bool SupportsRenderTargetFormat_PF_G8
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SupportsRenderTargetFormat_PF_G8, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SupportsRenderTargetFormat_PF_G8, __InBuffer);
				}
			}
		}

		public bool SupportsRenderTargetFormat_PF_FloatRGBA
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SupportsRenderTargetFormat_PF_FloatRGBA, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SupportsRenderTargetFormat_PF_FloatRGBA, __InBuffer);
				}
			}
		}

		public bool SupportsMultipleRenderTargets
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SupportsMultipleRenderTargets, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SupportsMultipleRenderTargets, __InBuffer);
				}
			}
		}

		private static uint __MaxShadowDepthBufferSizeX = 0;

		private static uint __MaxShadowDepthBufferSizeY = 0;

		private static uint __MaxTextureDimensions = 0;

		private static uint __MaxCubeTextureDimensions = 0;

		private static uint __SupportsRenderTargetFormat_PF_G8 = 0;

		private static uint __SupportsRenderTargetFormat_PF_FloatRGBA = 0;

		private static uint __SupportsMultipleRenderTargets = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}