using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraDataInterfaceGrid2DCollection")]
	public partial class UNiagaraDataInterfaceGrid2DCollection : UNiagaraDataInterfaceGrid2D, IStaticClass
	{
		public FNiagaraUserParameterBinding RenderTargetUserParameter
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RenderTargetUserParameter, __ReturnBuffer);

					return *(FNiagaraUserParameterBinding*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RenderTargetUserParameter, __InBuffer);
				}
			}
		}

		public ENiagaraGpuBufferFormat OverrideBufferFormat
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OverrideBufferFormat, __ReturnBuffer);

					return *(ENiagaraGpuBufferFormat*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OverrideBufferFormat, __InBuffer);
				}
			}
		}

		public bool bOverrideFormat
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bOverrideFormat, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bOverrideFormat, __InBuffer);
				}
			}
		}

		public bool bPreviewGrid
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bPreviewGrid, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bPreviewGrid, __InBuffer);
				}
			}
		}

		public FName PreviewAttribute
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PreviewAttribute, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PreviewAttribute, __InBuffer);
				}
			}
		}

		public TMap<ulong, UTextureRenderTarget2DArray> ManagedRenderTargets
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ManagedRenderTargets, __ReturnBuffer);

					return *(TMap<ulong, UTextureRenderTarget2DArray>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ManagedRenderTargets, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Niagara.NiagaraDataInterfaceGrid2DCollection");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void GetTextureSize(UNiagaraComponent Component, ref int SizeX, ref int SizeY)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Component?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = SizeX;

				*(int*)(__InBuffer + 12) = SizeY;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetTextureSize, __InBuffer, __OutBuffer);

				SizeX = *(int*)(__OutBuffer);

				SizeY = *(int*)(__OutBuffer + 4);

			}
		}

		public virtual void GetRawTextureSize(UNiagaraComponent Component, ref int SizeX, ref int SizeY)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Component?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = SizeX;

				*(int*)(__InBuffer + 12) = SizeY;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetRawTextureSize, __InBuffer, __OutBuffer);

				SizeX = *(int*)(__OutBuffer);

				SizeY = *(int*)(__OutBuffer + 4);

			}
		}

		public virtual bool FillTexture2D(UNiagaraComponent Component, UTextureRenderTarget2D dest, int AttributeIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = Component?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = dest?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = AttributeIndex;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __FillTexture2D, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool FillRawTexture2D(UNiagaraComponent Component, UTextureRenderTarget2D Dest, ref int TilesX, ref int TilesY)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Component?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Dest?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = TilesX;

				*(int*)(__InBuffer + 20) = TilesY;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __FillRawTexture2D, __InBuffer, __OutBuffer, __ReturnBuffer);

				TilesX = *(int*)(__OutBuffer);

				TilesY = *(int*)(__OutBuffer + 4);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __RenderTargetUserParameter = 0;

		private static uint __OverrideBufferFormat = 0;

		private static uint __bOverrideFormat = 0;

		private static uint __bPreviewGrid = 0;

		private static uint __PreviewAttribute = 0;

		private static uint __ManagedRenderTargets = 0;

		private static uint __GetTextureSize = 0;

		private static uint __GetRawTextureSize = 0;

		private static uint __FillTexture2D = 0;

		private static uint __FillRawTexture2D = 0;
	}
}