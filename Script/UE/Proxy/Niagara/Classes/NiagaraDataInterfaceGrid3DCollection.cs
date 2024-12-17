using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraDataInterfaceGrid3DCollection")]
	public partial class UNiagaraDataInterfaceGrid3DCollection : UNiagaraDataInterfaceGrid3D, IStaticClass
	{
		public int NumAttributes
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NumAttributes, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NumAttributes, __InBuffer);
				}
			}
		}

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

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Niagara.NiagaraDataInterfaceGrid3DCollection");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void GetTextureSize(UNiagaraComponent Component, ref int SizeX, ref int SizeY, ref int SizeZ)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = Component?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = SizeX;

				*(int*)(__InBuffer + 12) = SizeY;

				*(int*)(__InBuffer + 16) = SizeZ;

				var __OutBuffer = stackalloc byte[12];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetTextureSize, __InBuffer, __OutBuffer);

				SizeX = *(int*)(__OutBuffer);

				SizeY = *(int*)(__OutBuffer + 4);

				SizeZ = *(int*)(__OutBuffer + 8);

			}
		}

		public virtual void GetRawTextureSize(UNiagaraComponent Component, ref int SizeX, ref int SizeY, ref int SizeZ)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = Component?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = SizeX;

				*(int*)(__InBuffer + 12) = SizeY;

				*(int*)(__InBuffer + 16) = SizeZ;

				var __OutBuffer = stackalloc byte[12];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetRawTextureSize, __InBuffer, __OutBuffer);

				SizeX = *(int*)(__OutBuffer);

				SizeY = *(int*)(__OutBuffer + 4);

				SizeZ = *(int*)(__OutBuffer + 8);

			}
		}

		public virtual bool FillVolumeTexture(UNiagaraComponent Component, UVolumeTexture dest, int AttributeIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = Component?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = dest?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = AttributeIndex;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __FillVolumeTexture, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool FillRawVolumeTexture(UNiagaraComponent Component, UVolumeTexture Dest, ref int TilesX, ref int TilesY, ref int TileZ)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(nint*)(__InBuffer) = Component?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Dest?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = TilesX;

				*(int*)(__InBuffer + 20) = TilesY;

				*(int*)(__InBuffer + 24) = TileZ;

				var __OutBuffer = stackalloc byte[12];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __FillRawVolumeTexture, __InBuffer, __OutBuffer, __ReturnBuffer);

				TilesX = *(int*)(__OutBuffer);

				TilesY = *(int*)(__OutBuffer + 4);

				TileZ = *(int*)(__OutBuffer + 8);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __NumAttributes = 0;

		private static uint __RenderTargetUserParameter = 0;

		private static uint __OverrideBufferFormat = 0;

		private static uint __bOverrideFormat = 0;

		private static uint __bPreviewGrid = 0;

		private static uint __PreviewAttribute = 0;

		private static uint __GetTextureSize = 0;

		private static uint __GetRawTextureSize = 0;

		private static uint __FillVolumeTexture = 0;

		private static uint __FillRawVolumeTexture = 0;
	}
}