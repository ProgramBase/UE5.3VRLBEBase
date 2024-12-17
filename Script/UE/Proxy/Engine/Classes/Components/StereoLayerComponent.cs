using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.StereoLayerComponent")]
	public partial class UStereoLayerComponent : USceneComponent, IStaticClass
	{
		public bool bLiveTexture
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bLiveTexture, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bLiveTexture, __InBuffer);
				}
			}
		}

		public bool bSupportsDepth
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bSupportsDepth, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bSupportsDepth, __InBuffer);
				}
			}
		}

		public bool bNoAlphaChannel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bNoAlphaChannel, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bNoAlphaChannel, __InBuffer);
				}
			}
		}

		public UTexture Texture
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Texture, __ReturnBuffer);

					return *(UTexture*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Texture, __InBuffer);
				}
			}
		}

		public UTexture LeftTexture
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LeftTexture, __ReturnBuffer);

					return *(UTexture*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LeftTexture, __InBuffer);
				}
			}
		}

		public bool bQuadPreserveTextureRatio
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bQuadPreserveTextureRatio, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bQuadPreserveTextureRatio, __InBuffer);
				}
			}
		}

		public FVector2D QuadSize
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __QuadSize, __ReturnBuffer);

					return *(FVector2D*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __QuadSize, __InBuffer);
				}
			}
		}

		public FBox2D UVRect
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __UVRect, __ReturnBuffer);

					return *(FBox2D*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __UVRect, __InBuffer);
				}
			}
		}

		public EStereoLayerType StereoLayerType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StereoLayerType, __ReturnBuffer);

					return *(EStereoLayerType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StereoLayerType, __InBuffer);
				}
			}
		}

		public UStereoLayerShape Shape
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Shape, __ReturnBuffer);

					return *(UStereoLayerShape*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Shape, __InBuffer);
				}
			}
		}

		public int Priority
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Priority, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Priority, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.StereoLayerComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="InUVRect">
		/// : Min and Max UV coordinates
		/// </param>
		public virtual void SetUVRect(FBox2D InUVRect)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InUVRect?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetUVRect, __InBuffer);
			}
		}

		/// <param name="InTexture">
		/// : new Texture2D
		/// </param>
		public virtual void SetTexture(UTexture InTexture)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InTexture?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetTexture, __InBuffer);
			}
		}

		/// <param name="InQuadSize">
		/// : new quad size.
		/// </param>
		public virtual void SetQuadSize(FVector2D InQuadSize)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InQuadSize?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetQuadSize, __InBuffer);
			}
		}

		/// <param name="InPriority">
		/// : Priority value
		/// </param>
		public virtual void SetPriority(int InPriority)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = InPriority;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPriority, __InBuffer);
			}
		}

		/// <param name="InTexture">
		/// : new Texture2D
		/// </param>
		public virtual void SetLeftTexture(UTexture InTexture)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InTexture?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLeftTexture, __InBuffer);
			}
		}

		/// <param name="LeftScale">
		/// : Scale for left eye
		/// </param>
		/// <param name="LeftBias">
		/// : Bias for left eye
		/// </param>
		/// <param name="RightScale">
		/// : Scale for right eye
		/// </param>
		/// <param name="RightBias">
		/// : Bias for right eye
		/// </param>
		/// <param name="Radius">
		/// : sphere radius
		/// </param>
		public virtual void SetEquirectProps(FEquirectProps InEquirectProps)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InEquirectProps?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetEquirectProps, __InBuffer);
			}
		}

		public virtual void MarkTextureForUpdate()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __MarkTextureForUpdate);
			}
		}

		/// <returns>
		/// the UV coordinates mapped to the quad face
		/// </returns>
		public virtual FBox2D GetUVRect()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetUVRect, __ReturnBuffer);

				return *(FBox2D*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// the texture mapped to the stereo layer.
		/// </returns>
		public virtual UTexture GetTexture()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetTexture, __ReturnBuffer);

				return *(UTexture*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// the height and width of the rendered quad
		/// </returns>
		public virtual FVector2D GetQuadSize()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetQuadSize, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// the render priority
		/// </returns>
		public virtual int GetPriority()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetPriority, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// the texture mapped to the stereo layer for left eye, if stereoscopic layer textures are supported on the platform.
		/// </returns>
		public virtual UTexture GetLeftTexture()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetLeftTexture, __ReturnBuffer);

				return *(UTexture*)__ReturnBuffer;
			}
		}

		private static uint __bLiveTexture = 0;

		private static uint __bSupportsDepth = 0;

		private static uint __bNoAlphaChannel = 0;

		private static uint __Texture = 0;

		private static uint __LeftTexture = 0;

		private static uint __bQuadPreserveTextureRatio = 0;

		private static uint __QuadSize = 0;

		private static uint __UVRect = 0;

		private static uint __StereoLayerType = 0;

		private static uint __Shape = 0;

		private static uint __Priority = 0;

		private static uint __SetUVRect = 0;

		private static uint __SetTexture = 0;

		private static uint __SetQuadSize = 0;

		private static uint __SetPriority = 0;

		private static uint __SetLeftTexture = 0;

		private static uint __SetEquirectProps = 0;

		private static uint __MarkTextureForUpdate = 0;

		private static uint __GetUVRect = 0;

		private static uint __GetTexture = 0;

		private static uint __GetQuadSize = 0;

		private static uint __GetPriority = 0;

		private static uint __GetLeftTexture = 0;
	}
}