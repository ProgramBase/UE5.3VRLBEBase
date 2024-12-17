using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.StreamingRenderAssetPrimitiveInfo")]
	public partial class FStreamingRenderAssetPrimitiveInfo : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.StreamingRenderAssetPrimitiveInfo");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FStreamingRenderAssetPrimitiveInfo() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FStreamingRenderAssetPrimitiveInfo() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FStreamingRenderAssetPrimitiveInfo A, FStreamingRenderAssetPrimitiveInfo B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FStreamingRenderAssetPrimitiveInfo A, FStreamingRenderAssetPrimitiveInfo B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FStreamingRenderAssetPrimitiveInfo;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UStreamableRenderAsset RenderAsset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RenderAsset, __ReturnBuffer);

					return *(UStreamableRenderAsset*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RenderAsset, __InBuffer);
				}
			}
		}

		public FBoxSphereBounds Bounds
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Bounds, __ReturnBuffer);

					return *(FBoxSphereBounds*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Bounds, __InBuffer);
				}
			}
		}

		public float TexelFactor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TexelFactor, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TexelFactor, __InBuffer);
				}
			}
		}

		public uint PackedRelativeBox
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PackedRelativeBox, __ReturnBuffer);

					return *(uint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(uint*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PackedRelativeBox, __InBuffer);
				}
			}
		}

		public bool bAllowInvalidTexelFactorWhenUnregistered
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bAllowInvalidTexelFactorWhenUnregistered, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bAllowInvalidTexelFactorWhenUnregistered, __InBuffer);
				}
			}
		}

		public bool bAffectedByComponentScale
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bAffectedByComponentScale, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bAffectedByComponentScale, __InBuffer);
				}
			}
		}

		private static uint __RenderAsset = 0;

		private static uint __Bounds = 0;

		private static uint __TexelFactor = 0;

		private static uint __PackedRelativeBox = 0;

		private static uint __bAllowInvalidTexelFactorWhenUnregistered = 0;

		private static uint __bAffectedByComponentScale = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}