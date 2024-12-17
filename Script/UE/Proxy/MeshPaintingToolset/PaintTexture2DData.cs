using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.MeshPaintingToolset
{
	[PathName("/Script/MeshPaintingToolset.PaintTexture2DData")]
	public partial class FPaintTexture2DData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MeshPaintingToolset.PaintTexture2DData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPaintTexture2DData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPaintTexture2DData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPaintTexture2DData A, FPaintTexture2DData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPaintTexture2DData A, FPaintTexture2DData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPaintTexture2DData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UTexture2D PaintingTexture2D
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PaintingTexture2D, __ReturnBuffer);

					return *(UTexture2D*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PaintingTexture2D, __InBuffer);
				}
			}
		}

		public bool bIsPaintingTexture2DModified
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bIsPaintingTexture2DModified, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bIsPaintingTexture2DModified, __InBuffer);
				}
			}
		}

		public UTexture2D ScratchTexture
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ScratchTexture, __ReturnBuffer);

					return *(UTexture2D*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ScratchTexture, __InBuffer);
				}
			}
		}

		public UTextureRenderTarget2D PaintRenderTargetTexture
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PaintRenderTargetTexture, __ReturnBuffer);

					return *(UTextureRenderTarget2D*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PaintRenderTargetTexture, __InBuffer);
				}
			}
		}

		public TArray<UMeshComponent> PaintedComponents
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PaintedComponents, __ReturnBuffer);

					return *(TArray<UMeshComponent>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PaintedComponents, __InBuffer);
				}
			}
		}

		public UTextureRenderTarget2D PaintBrushRenderTargetTexture
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PaintBrushRenderTargetTexture, __ReturnBuffer);

					return *(UTextureRenderTarget2D*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PaintBrushRenderTargetTexture, __InBuffer);
				}
			}
		}

		private static uint __PaintingTexture2D = 0;

		private static uint __bIsPaintingTexture2DModified = 0;

		private static uint __ScratchTexture = 0;

		private static uint __PaintRenderTargetTexture = 0;

		private static uint __PaintedComponents = 0;

		private static uint __PaintBrushRenderTargetTexture = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}