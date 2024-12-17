using Script.CoreUObject;
using Script.Engine;
using Script.Library;
using Script.SlateCore;

namespace Script.UMG
{
	[PathName("/Script/UMG.SlateBlueprintLibrary")]
	public partial class USlateBlueprintLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.SlateBlueprintLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static FVector2D TransformVectorLocalToAbsolute(FGeometry Geometry, FVector2D LocalVector)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Geometry?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = LocalVector?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __TransformVectorLocalToAbsolute, __InBuffer, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		public static FVector2D TransformVectorAbsoluteToLocal(FGeometry Geometry, FVector2D AbsoluteVector)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Geometry?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AbsoluteVector?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __TransformVectorAbsoluteToLocal, __InBuffer, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		public static float TransformScalarLocalToAbsolute(FGeometry Geometry, float LocalScalar)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = Geometry?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = LocalScalar;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __TransformScalarLocalToAbsolute, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public static float TransformScalarAbsoluteToLocal(FGeometry Geometry, float AbsoluteScalar)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = Geometry?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = AbsoluteScalar;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __TransformScalarAbsoluteToLocal, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public static void ScreenToWidgetLocal(UObject WorldContextObject, FGeometry Geometry, FVector2D ScreenPosition, ref FVector2D LocalCoordinate, bool bIncludeWindowPosition)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[33];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Geometry?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ScreenPosition?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = LocalCoordinate?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 32) = bIncludeWindowPosition;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __ScreenToWidgetLocal, __InBuffer, __OutBuffer);

				LocalCoordinate = *(FVector2D*)(__OutBuffer);

			}
		}

		public static void ScreenToWidgetAbsolute(UObject WorldContextObject, FVector2D ScreenPosition, ref FVector2D AbsoluteCoordinate, bool bIncludeWindowPosition)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ScreenPosition?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = AbsoluteCoordinate?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bIncludeWindowPosition;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __ScreenToWidgetAbsolute, __InBuffer, __OutBuffer);

				AbsoluteCoordinate = *(FVector2D*)(__OutBuffer);

			}
		}

		public static void ScreenToViewport(UObject WorldContextObject, FVector2D ScreenPosition, ref FVector2D ViewportPosition)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ScreenPosition?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ViewportPosition?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __ScreenToViewport, __InBuffer, __OutBuffer);

				ViewportPosition = *(FVector2D*)(__OutBuffer);

			}
		}

		/// <param name="PixelPosition">
		/// The position in the game's viewport, usable for line traces and 
		/// other uses where you need a coordinate in the space of viewport resolution units.
		/// </param>
		/// <param name="ViewportPosition">
		/// The position in the space of other widgets in the viewport.  Like if you wanted
		/// to add another widget to the viewport at the same position in viewport space as this location, this is
		/// what you would use.
		/// </param>
		public static void LocalToViewport(UObject WorldContextObject, FGeometry Geometry, FVector2D LocalCoordinate, ref FVector2D PixelPosition, ref FVector2D ViewportPosition)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[40];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Geometry?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = LocalCoordinate?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = PixelPosition?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = ViewportPosition?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[16];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __LocalToViewport, __InBuffer, __OutBuffer);

				PixelPosition = *(FVector2D*)(__OutBuffer);

				ViewportPosition = *(FVector2D*)(__OutBuffer + 8);

			}
		}

		/// <returns>
		/// Absolute coordinates
		/// </returns>
		public static FVector2D LocalToAbsolute(FGeometry Geometry, FVector2D LocalCoordinate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Geometry?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = LocalCoordinate?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __LocalToAbsolute, __InBuffer, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// true if the provided location in absolute coordinates is within the bounds of this geometry.
		/// </returns>
		public static bool IsUnderLocation(FGeometry Geometry, FVector2D AbsoluteCoordinate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Geometry?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AbsoluteCoordinate?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsUnderLocation, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static FVector2D GetLocalTopLeft(FGeometry Geometry)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Geometry?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetLocalTopLeft, __InBuffer, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		public static FVector2D GetLocalSize(FGeometry Geometry)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Geometry?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetLocalSize, __InBuffer, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		public static FVector2D GetAbsoluteSize(FGeometry Geometry)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Geometry?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetAbsoluteSize, __InBuffer, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		public static bool EqualEqual_SlateBrush(FSlateBrush A, FSlateBrush B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __EqualEqual_SlateBrush, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="PixelPosition">
		/// The position in the game's viewport, usable for line traces and
		/// other uses where you need a coordinate in the space of viewport resolution units.
		/// </param>
		/// <param name="ViewportPosition">
		/// The position in the space of other widgets in the viewport.  Like if you wanted
		/// to add another widget to the viewport at the same position in viewport space as this location, this is
		/// what you would use.
		/// </param>
		public static void AbsoluteToViewport(UObject WorldContextObject, FVector2D AbsoluteDesktopCoordinate, ref FVector2D PixelPosition, ref FVector2D ViewportPosition)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AbsoluteDesktopCoordinate?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = PixelPosition?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = ViewportPosition?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[16];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __AbsoluteToViewport, __InBuffer, __OutBuffer);

				PixelPosition = *(FVector2D*)(__OutBuffer);

				ViewportPosition = *(FVector2D*)(__OutBuffer + 8);

			}
		}

		/// <returns>
		/// Transforms AbsoluteCoordinate into the local space of this Geometry.
		/// </returns>
		public static FVector2D AbsoluteToLocal(FGeometry Geometry, FVector2D AbsoluteCoordinate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Geometry?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AbsoluteCoordinate?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __AbsoluteToLocal, __InBuffer, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		private static uint __TransformVectorLocalToAbsolute = 0;

		private static uint __TransformVectorAbsoluteToLocal = 0;

		private static uint __TransformScalarLocalToAbsolute = 0;

		private static uint __TransformScalarAbsoluteToLocal = 0;

		private static uint __ScreenToWidgetLocal = 0;

		private static uint __ScreenToWidgetAbsolute = 0;

		private static uint __ScreenToViewport = 0;

		private static uint __LocalToViewport = 0;

		private static uint __LocalToAbsolute = 0;

		private static uint __IsUnderLocation = 0;

		private static uint __GetLocalTopLeft = 0;

		private static uint __GetLocalSize = 0;

		private static uint __GetAbsoluteSize = 0;

		private static uint __EqualEqual_SlateBrush = 0;

		private static uint __AbsoluteToViewport = 0;

		private static uint __AbsoluteToLocal = 0;
	}
}