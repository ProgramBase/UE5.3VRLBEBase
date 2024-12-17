using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.CanvasRenderTarget2D")]
	public partial class UCanvasRenderTarget2D : UTextureRenderTarget2D, IStaticClass
	{
		public FOnCanvasRenderTargetUpdate OnCanvasRenderTargetUpdate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnCanvasRenderTargetUpdate, __ReturnBuffer);

					return *(FOnCanvasRenderTargetUpdate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnCanvasRenderTargetUpdate, __InBuffer);
				}
			}
		}

		public TWeakObjectPtr<UWorld> World
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __World, __ReturnBuffer);

					return *(TWeakObjectPtr<UWorld>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __World, __InBuffer);
				}
			}
		}

		public bool bShouldClearRenderTargetOnReceiveUpdate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bShouldClearRenderTargetOnReceiveUpdate, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bShouldClearRenderTargetOnReceiveUpdate, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.CanvasRenderTarget2D");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void UpdateResource()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __UpdateResource);
			}
		}

		/// <param name="Canvas">
		/// Canvas object that can be used to paint to the render target
		/// </param>
		/// <param name="Width">
		/// Width of the render target.
		/// </param>
		/// <param name="Height">
		/// Height of the render target.
		/// </param>
		public virtual void ReceiveUpdate(UCanvas Canvas, int Width, int Height)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Canvas?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Width;

				*(int*)(__InBuffer + 12) = Height;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ReceiveUpdate, __InBuffer);
			}
		}

		/// <param name="Width">
		/// Output variable for the render target's width
		/// </param>
		/// <param name="Height">
		/// Output variable for the render target's height
		/// </param>
		public virtual void GetSize(ref int Width, ref int Height)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = Width;

				*(int*)(__InBuffer + 4) = Height;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetSize, __InBuffer, __OutBuffer);

				Width = *(int*)(__OutBuffer);

				Height = *(int*)(__OutBuffer + 4);

			}
		}

		/// <param name="WorldContextObject">
		/// The world where this render target will be rendered for
		/// </param>
		/// <param name="CanvasRenderTarget2DClass">
		/// Class of the render target.  Unless you want to use a special sub-class, you can simply pass UCanvasRenderTarget2D::StaticClass() here.
		/// </param>
		/// <param name="Width">
		/// Width of the render target.
		/// </param>
		/// <param name="Height">
		/// Height of the render target.
		/// </param>
		/// <returns>
		/// Returns the instanced render target.
		/// </returns>
		public static UCanvasRenderTarget2D CreateCanvasRenderTarget2D(UObject WorldContextObject, TSubclassOf<UCanvasRenderTarget2D> CanvasRenderTarget2DClass, int Width = 1024, int Height = 1024)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = CanvasRenderTarget2DClass?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = Width;

				*(int*)(__InBuffer + 20) = Height;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateCanvasRenderTarget2D, __InBuffer, __ReturnBuffer);

				return *(UCanvasRenderTarget2D*)__ReturnBuffer;
			}
		}

		private static uint __OnCanvasRenderTargetUpdate = 0;

		private static uint __World = 0;

		private static uint __bShouldClearRenderTargetOnReceiveUpdate = 0;

		private static uint __UpdateResource = 0;

		private static uint __ReceiveUpdate = 0;

		private static uint __GetSize = 0;

		private static uint __CreateCanvasRenderTarget2D = 0;
	}
}