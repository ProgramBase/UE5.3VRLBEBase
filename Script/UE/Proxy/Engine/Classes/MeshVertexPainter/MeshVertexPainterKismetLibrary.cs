using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MeshVertexPainterKismetLibrary")]
	public partial class UMeshVertexPainterKismetLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MeshVertexPainterKismetLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static void RemovePaintedVertices(UStaticMeshComponent StaticMeshComponent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = StaticMeshComponent?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __RemovePaintedVertices, __InBuffer);
			}
		}

		public static void PaintVerticesSingleColor(UStaticMeshComponent StaticMeshComponent, FLinearColor FillColor, bool bConvertToSRGB = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = StaticMeshComponent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = FillColor?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bConvertToSRGB;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __PaintVerticesSingleColor, __InBuffer);
			}
		}

		public static void PaintVerticesLerpAlongAxis(UStaticMeshComponent StaticMeshComponent, FLinearColor StartColor, FLinearColor EndColor, EVertexPaintAxis Axis, bool bConvertToSRGB = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[26];

				*(nint*)(__InBuffer) = StaticMeshComponent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = StartColor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = EndColor?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 24) = (byte)Axis;

				*(bool*)(__InBuffer + 25) = bConvertToSRGB;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __PaintVerticesLerpAlongAxis, __InBuffer);
			}
		}

		private static uint __RemovePaintedVertices = 0;

		private static uint __PaintVerticesSingleColor = 0;

		private static uint __PaintVerticesLerpAlongAxis = 0;
	}
}