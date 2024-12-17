using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SplineComponent")]
	public partial class USplineComponent : UPrimitiveComponent, IStaticClass
	{
		public FSplineCurves SplineCurves
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SplineCurves, __ReturnBuffer);

					return *(FSplineCurves*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SplineCurves, __InBuffer);
				}
			}
		}

		public int ReparamStepsPerSegment
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ReparamStepsPerSegment, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ReparamStepsPerSegment, __InBuffer);
				}
			}
		}

		public float Duration
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Duration, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Duration, __InBuffer);
				}
			}
		}

		public bool bStationaryEndpoints
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bStationaryEndpoints, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bStationaryEndpoints, __InBuffer);
				}
			}
		}

		public bool bSplineHasBeenEdited
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bSplineHasBeenEdited, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bSplineHasBeenEdited, __InBuffer);
				}
			}
		}

		public bool bModifiedByConstructionScript
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bModifiedByConstructionScript, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bModifiedByConstructionScript, __InBuffer);
				}
			}
		}

		public bool bInputSplinePointsToConstructionScript
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bInputSplinePointsToConstructionScript, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bInputSplinePointsToConstructionScript, __InBuffer);
				}
			}
		}

		public bool bDrawDebug
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bDrawDebug, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bDrawDebug, __InBuffer);
				}
			}
		}

		public bool bClosedLoop
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bClosedLoop, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bClosedLoop, __InBuffer);
				}
			}
		}

		public bool bLoopPositionOverride
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bLoopPositionOverride, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bLoopPositionOverride, __InBuffer);
				}
			}
		}

		public float LoopPosition
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LoopPosition, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LoopPosition, __InBuffer);
				}
			}
		}

		public FVector DefaultUpVector
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultUpVector, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultUpVector, __InBuffer);
				}
			}
		}

		public FLinearColor EditorUnselectedSplineSegmentColor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EditorUnselectedSplineSegmentColor, __ReturnBuffer);

					return *(FLinearColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EditorUnselectedSplineSegmentColor, __InBuffer);
				}
			}
		}

		public FLinearColor EditorSelectedSplineSegmentColor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EditorSelectedSplineSegmentColor, __ReturnBuffer);

					return *(FLinearColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EditorSelectedSplineSegmentColor, __InBuffer);
				}
			}
		}

		public FLinearColor EditorTangentColor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EditorTangentColor, __ReturnBuffer);

					return *(FLinearColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EditorTangentColor, __InBuffer);
				}
			}
		}

		public bool bAllowDiscontinuousSpline
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAllowDiscontinuousSpline, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAllowDiscontinuousSpline, __InBuffer);
				}
			}
		}

		public bool bShouldVisualizeScale
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bShouldVisualizeScale, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bShouldVisualizeScale, __InBuffer);
				}
			}
		}

		public float ScaleVisualizationWidth
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ScaleVisualizationWidth, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ScaleVisualizationWidth, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.SplineComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void UpdateSpline()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __UpdateSpline);
			}
		}

		public virtual void SetWorldLocationAtSplinePoint(int PointIndex, FVector InLocation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = PointIndex;

				*(nint*)(__InBuffer + 4) = InLocation?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetWorldLocationAtSplinePoint, __InBuffer);
			}
		}

		public virtual void SetUpVectorAtSplinePoint(int PointIndex, FVector InUpVector, ESplineCoordinateSpace CoordinateSpace, bool bUpdateSpline = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[14];

				*(int*)(__InBuffer) = PointIndex;

				*(nint*)(__InBuffer + 4) = InUpVector?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 12) = (byte)CoordinateSpace;

				*(bool*)(__InBuffer + 13) = bUpdateSpline;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetUpVectorAtSplinePoint, __InBuffer);
			}
		}

		public virtual void SetUnselectedSplineSegmentColor(FLinearColor SegmentColor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SegmentColor?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetUnselectedSplineSegmentColor, __InBuffer);
			}
		}

		public virtual void SetTangentsAtSplinePoint(int PointIndex, FVector InArriveTangent, FVector InLeaveTangent, ESplineCoordinateSpace CoordinateSpace, bool bUpdateSpline = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[22];

				*(int*)(__InBuffer) = PointIndex;

				*(nint*)(__InBuffer + 4) = InArriveTangent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 12) = InLeaveTangent?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 20) = (byte)CoordinateSpace;

				*(bool*)(__InBuffer + 21) = bUpdateSpline;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetTangentsAtSplinePoint, __InBuffer);
			}
		}

		public virtual void SetTangentColor(FLinearColor TangentColor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = TangentColor?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetTangentColor, __InBuffer);
			}
		}

		public virtual void SetTangentAtSplinePoint(int PointIndex, FVector InTangent, ESplineCoordinateSpace CoordinateSpace, bool bUpdateSpline = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[14];

				*(int*)(__InBuffer) = PointIndex;

				*(nint*)(__InBuffer + 4) = InTangent?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 12) = (byte)CoordinateSpace;

				*(bool*)(__InBuffer + 13) = bUpdateSpline;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetTangentAtSplinePoint, __InBuffer);
			}
		}

		public virtual void SetSplineWorldPoints(TArray<FVector> Points)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Points?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSplineWorldPoints, __InBuffer);
			}
		}

		public virtual void SetSplinePointType(int PointIndex, ESplinePointType Type, bool bUpdateSpline = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[6];

				*(int*)(__InBuffer) = PointIndex;

				*(byte*)(__InBuffer + 4) = (byte)Type;

				*(bool*)(__InBuffer + 5) = bUpdateSpline;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSplinePointType, __InBuffer);
			}
		}

		public virtual void SetSplinePoints(TArray<FVector> Points, ESplineCoordinateSpace CoordinateSpace, bool bUpdateSpline = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = Points?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)CoordinateSpace;

				*(bool*)(__InBuffer + 9) = bUpdateSpline;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSplinePoints, __InBuffer);
			}
		}

		public virtual void SetSplineLocalPoints(TArray<FVector> Points)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Points?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSplineLocalPoints, __InBuffer);
			}
		}

		public virtual void SetSelectedSplineSegmentColor(FLinearColor SegmentColor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SegmentColor?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSelectedSplineSegmentColor, __InBuffer);
			}
		}

		public virtual void SetScaleAtSplinePoint(int PointIndex, FVector InScaleVector, bool bUpdateSpline = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(int*)(__InBuffer) = PointIndex;

				*(nint*)(__InBuffer + 4) = InScaleVector?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 12) = bUpdateSpline;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetScaleAtSplinePoint, __InBuffer);
			}
		}

		public virtual void SetRotationAtSplinePoint(int PointIndex, FRotator InRotation, ESplineCoordinateSpace CoordinateSpace, bool bUpdateSpline = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[14];

				*(int*)(__InBuffer) = PointIndex;

				*(nint*)(__InBuffer + 4) = InRotation?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 12) = (byte)CoordinateSpace;

				*(bool*)(__InBuffer + 13) = bUpdateSpline;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetRotationAtSplinePoint, __InBuffer);
			}
		}

		public virtual void SetLocationAtSplinePoint(int PointIndex, FVector InLocation, ESplineCoordinateSpace CoordinateSpace, bool bUpdateSpline = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[14];

				*(int*)(__InBuffer) = PointIndex;

				*(nint*)(__InBuffer + 4) = InLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 12) = (byte)CoordinateSpace;

				*(bool*)(__InBuffer + 13) = bUpdateSpline;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLocationAtSplinePoint, __InBuffer);
			}
		}

		public virtual void SetDrawDebug(bool bShow)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bShow;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDrawDebug, __InBuffer);
			}
		}

		public virtual void SetDefaultUpVector(FVector UpVector, ESplineCoordinateSpace CoordinateSpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = UpVector?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)CoordinateSpace;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDefaultUpVector, __InBuffer);
			}
		}

		public virtual void SetClosedLoopAtPosition(bool bInClosedLoop, float Key, bool bUpdateSpline = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[6];

				*(bool*)(__InBuffer) = bInClosedLoop;

				*(float*)(__InBuffer + 1) = Key;

				*(bool*)(__InBuffer + 5) = bUpdateSpline;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetClosedLoopAtPosition, __InBuffer);
			}
		}

		public virtual void SetClosedLoop(bool bInClosedLoop, bool bUpdateSpline = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[2];

				*(bool*)(__InBuffer) = bInClosedLoop;

				*(bool*)(__InBuffer + 1) = bUpdateSpline;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetClosedLoop, __InBuffer);
			}
		}

		public virtual void RemoveSplinePoint(int Index, bool bUpdateSpline = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(int*)(__InBuffer) = Index;

				*(bool*)(__InBuffer + 4) = bUpdateSpline;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RemoveSplinePoint, __InBuffer);
			}
		}

		public virtual bool IsClosedLoop()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsClosedLoop, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual FVector GetWorldTangentAtDistanceAlongSpline(float Distance)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Distance;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetWorldTangentAtDistanceAlongSpline, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual FRotator GetWorldRotationAtTime(float Time, bool bUseConstantVelocity = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(float*)(__InBuffer) = Time;

				*(bool*)(__InBuffer + 4) = bUseConstantVelocity;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetWorldRotationAtTime, __InBuffer, __ReturnBuffer);

				return *(FRotator*)__ReturnBuffer;
			}
		}

		public virtual FRotator GetWorldRotationAtDistanceAlongSpline(float Distance)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Distance;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetWorldRotationAtDistanceAlongSpline, __InBuffer, __ReturnBuffer);

				return *(FRotator*)__ReturnBuffer;
			}
		}

		public virtual FVector GetWorldLocationAtTime(float Time, bool bUseConstantVelocity = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(float*)(__InBuffer) = Time;

				*(bool*)(__InBuffer + 4) = bUseConstantVelocity;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetWorldLocationAtTime, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual FVector GetWorldLocationAtSplinePoint(int PointIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = PointIndex;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetWorldLocationAtSplinePoint, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual FVector GetWorldLocationAtDistanceAlongSpline(float Distance)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Distance;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetWorldLocationAtDistanceAlongSpline, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual FVector GetWorldDirectionAtTime(float Time, bool bUseConstantVelocity = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(float*)(__InBuffer) = Time;

				*(bool*)(__InBuffer + 4) = bUseConstantVelocity;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetWorldDirectionAtTime, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual FVector GetWorldDirectionAtDistanceAlongSpline(float Distance)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Distance;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetWorldDirectionAtDistanceAlongSpline, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual FVector GetVectorPropertyAtSplinePoint(int Index, FName PropertyName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = Index;

				*(nint*)(__InBuffer + 4) = PropertyName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetVectorPropertyAtSplinePoint, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual FVector GetVectorPropertyAtSplineInputKey(float InKey, FName PropertyName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(float*)(__InBuffer) = InKey;

				*(nint*)(__InBuffer + 4) = PropertyName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetVectorPropertyAtSplineInputKey, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual FVector GetUpVectorAtTime(float Time, ESplineCoordinateSpace CoordinateSpace, bool bUseConstantVelocity = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[6];

				*(float*)(__InBuffer) = Time;

				*(byte*)(__InBuffer + 4) = (byte)CoordinateSpace;

				*(bool*)(__InBuffer + 5) = bUseConstantVelocity;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetUpVectorAtTime, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual FVector GetUpVectorAtSplinePoint(int PointIndex, ESplineCoordinateSpace CoordinateSpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(int*)(__InBuffer) = PointIndex;

				*(byte*)(__InBuffer + 4) = (byte)CoordinateSpace;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetUpVectorAtSplinePoint, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual FVector GetUpVectorAtSplineInputKey(float InKey, ESplineCoordinateSpace CoordinateSpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(float*)(__InBuffer) = InKey;

				*(byte*)(__InBuffer + 4) = (byte)CoordinateSpace;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetUpVectorAtSplineInputKey, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual FVector GetUpVectorAtDistanceAlongSpline(float Distance, ESplineCoordinateSpace CoordinateSpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(float*)(__InBuffer) = Distance;

				*(byte*)(__InBuffer + 4) = (byte)CoordinateSpace;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetUpVectorAtDistanceAlongSpline, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual FTransform GetTransformAtTime(float Time, ESplineCoordinateSpace CoordinateSpace, bool bUseConstantVelocity = false, bool bUseScale = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[7];

				*(float*)(__InBuffer) = Time;

				*(byte*)(__InBuffer + 4) = (byte)CoordinateSpace;

				*(bool*)(__InBuffer + 5) = bUseConstantVelocity;

				*(bool*)(__InBuffer + 6) = bUseScale;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetTransformAtTime, __InBuffer, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		public virtual FTransform GetTransformAtSplinePoint(int PointIndex, ESplineCoordinateSpace CoordinateSpace, bool bUseScale = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[6];

				*(int*)(__InBuffer) = PointIndex;

				*(byte*)(__InBuffer + 4) = (byte)CoordinateSpace;

				*(bool*)(__InBuffer + 5) = bUseScale;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetTransformAtSplinePoint, __InBuffer, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		public virtual FTransform GetTransformAtSplineInputKey(float InKey, ESplineCoordinateSpace CoordinateSpace, bool bUseScale = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[6];

				*(float*)(__InBuffer) = InKey;

				*(byte*)(__InBuffer + 4) = (byte)CoordinateSpace;

				*(bool*)(__InBuffer + 5) = bUseScale;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetTransformAtSplineInputKey, __InBuffer, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		public virtual FTransform GetTransformAtDistanceAlongSpline(float Distance, ESplineCoordinateSpace CoordinateSpace, bool bUseScale = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[6];

				*(float*)(__InBuffer) = Distance;

				*(byte*)(__InBuffer + 4) = (byte)CoordinateSpace;

				*(bool*)(__InBuffer + 5) = bUseScale;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetTransformAtDistanceAlongSpline, __InBuffer, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		public virtual float GetTimeAtDistanceAlongSpline(float Distance)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Distance;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetTimeAtDistanceAlongSpline, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual FVector GetTangentAtTime(float Time, ESplineCoordinateSpace CoordinateSpace, bool bUseConstantVelocity = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[6];

				*(float*)(__InBuffer) = Time;

				*(byte*)(__InBuffer + 4) = (byte)CoordinateSpace;

				*(bool*)(__InBuffer + 5) = bUseConstantVelocity;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetTangentAtTime, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual FVector GetTangentAtSplinePoint(int PointIndex, ESplineCoordinateSpace CoordinateSpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(int*)(__InBuffer) = PointIndex;

				*(byte*)(__InBuffer + 4) = (byte)CoordinateSpace;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetTangentAtSplinePoint, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual FVector GetTangentAtSplineInputKey(float InKey, ESplineCoordinateSpace CoordinateSpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(float*)(__InBuffer) = InKey;

				*(byte*)(__InBuffer + 4) = (byte)CoordinateSpace;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetTangentAtSplineInputKey, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual FVector GetTangentAtDistanceAlongSpline(float Distance, ESplineCoordinateSpace CoordinateSpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(float*)(__InBuffer) = Distance;

				*(byte*)(__InBuffer + 4) = (byte)CoordinateSpace;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetTangentAtDistanceAlongSpline, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual ESplinePointType GetSplinePointType(int PointIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = PointIndex;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetSplinePointType, __InBuffer, __ReturnBuffer);

				return *(ESplinePointType*)__ReturnBuffer;
			}
		}

		public virtual FSplinePoint GetSplinePointAt(int PointIndex, ESplineCoordinateSpace CoordinateSpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(int*)(__InBuffer) = PointIndex;

				*(byte*)(__InBuffer + 4) = (byte)CoordinateSpace;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetSplinePointAt, __InBuffer, __ReturnBuffer);

				return *(FSplinePoint*)__ReturnBuffer;
			}
		}

		public virtual float GetSplineLength()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetSplineLength, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual FVector GetScaleAtTime(float Time, bool bUseConstantVelocity = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(float*)(__InBuffer) = Time;

				*(bool*)(__InBuffer + 4) = bUseConstantVelocity;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetScaleAtTime, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual FVector GetScaleAtSplinePoint(int PointIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = PointIndex;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetScaleAtSplinePoint, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual FVector GetScaleAtSplineInputKey(float InKey)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InKey;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetScaleAtSplineInputKey, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual FVector GetScaleAtDistanceAlongSpline(float Distance)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Distance;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetScaleAtDistanceAlongSpline, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual FRotator GetRotationAtTime(float Time, ESplineCoordinateSpace CoordinateSpace, bool bUseConstantVelocity = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[6];

				*(float*)(__InBuffer) = Time;

				*(byte*)(__InBuffer + 4) = (byte)CoordinateSpace;

				*(bool*)(__InBuffer + 5) = bUseConstantVelocity;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetRotationAtTime, __InBuffer, __ReturnBuffer);

				return *(FRotator*)__ReturnBuffer;
			}
		}

		public virtual FRotator GetRotationAtSplinePoint(int PointIndex, ESplineCoordinateSpace CoordinateSpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(int*)(__InBuffer) = PointIndex;

				*(byte*)(__InBuffer + 4) = (byte)CoordinateSpace;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetRotationAtSplinePoint, __InBuffer, __ReturnBuffer);

				return *(FRotator*)__ReturnBuffer;
			}
		}

		public virtual FRotator GetRotationAtSplineInputKey(float InKey, ESplineCoordinateSpace CoordinateSpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(float*)(__InBuffer) = InKey;

				*(byte*)(__InBuffer + 4) = (byte)CoordinateSpace;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetRotationAtSplineInputKey, __InBuffer, __ReturnBuffer);

				return *(FRotator*)__ReturnBuffer;
			}
		}

		public virtual FRotator GetRotationAtDistanceAlongSpline(float Distance, ESplineCoordinateSpace CoordinateSpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(float*)(__InBuffer) = Distance;

				*(byte*)(__InBuffer + 4) = (byte)CoordinateSpace;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetRotationAtDistanceAlongSpline, __InBuffer, __ReturnBuffer);

				return *(FRotator*)__ReturnBuffer;
			}
		}

		public virtual float GetRollAtTime(float Time, ESplineCoordinateSpace CoordinateSpace, bool bUseConstantVelocity = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[6];

				*(float*)(__InBuffer) = Time;

				*(byte*)(__InBuffer + 4) = (byte)CoordinateSpace;

				*(bool*)(__InBuffer + 5) = bUseConstantVelocity;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetRollAtTime, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetRollAtSplinePoint(int PointIndex, ESplineCoordinateSpace CoordinateSpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(int*)(__InBuffer) = PointIndex;

				*(byte*)(__InBuffer + 4) = (byte)CoordinateSpace;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetRollAtSplinePoint, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetRollAtSplineInputKey(float InKey, ESplineCoordinateSpace CoordinateSpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(float*)(__InBuffer) = InKey;

				*(byte*)(__InBuffer + 4) = (byte)CoordinateSpace;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetRollAtSplineInputKey, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetRollAtDistanceAlongSpline(float Distance, ESplineCoordinateSpace CoordinateSpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(float*)(__InBuffer) = Distance;

				*(byte*)(__InBuffer + 4) = (byte)CoordinateSpace;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetRollAtDistanceAlongSpline, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual FVector GetRightVectorAtTime(float Time, ESplineCoordinateSpace CoordinateSpace, bool bUseConstantVelocity = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[6];

				*(float*)(__InBuffer) = Time;

				*(byte*)(__InBuffer + 4) = (byte)CoordinateSpace;

				*(bool*)(__InBuffer + 5) = bUseConstantVelocity;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetRightVectorAtTime, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual FVector GetRightVectorAtSplinePoint(int PointIndex, ESplineCoordinateSpace CoordinateSpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(int*)(__InBuffer) = PointIndex;

				*(byte*)(__InBuffer + 4) = (byte)CoordinateSpace;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetRightVectorAtSplinePoint, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual FVector GetRightVectorAtSplineInputKey(float InKey, ESplineCoordinateSpace CoordinateSpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(float*)(__InBuffer) = InKey;

				*(byte*)(__InBuffer + 4) = (byte)CoordinateSpace;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetRightVectorAtSplineInputKey, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual FVector GetRightVectorAtDistanceAlongSpline(float Distance, ESplineCoordinateSpace CoordinateSpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(float*)(__InBuffer) = Distance;

				*(byte*)(__InBuffer + 4) = (byte)CoordinateSpace;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetRightVectorAtDistanceAlongSpline, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual int GetNumberOfSplineSegments()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetNumberOfSplineSegments, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual int GetNumberOfSplinePoints()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetNumberOfSplinePoints, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual FVector GetLocationAtTime(float Time, ESplineCoordinateSpace CoordinateSpace, bool bUseConstantVelocity = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[6];

				*(float*)(__InBuffer) = Time;

				*(byte*)(__InBuffer + 4) = (byte)CoordinateSpace;

				*(bool*)(__InBuffer + 5) = bUseConstantVelocity;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetLocationAtTime, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual FVector GetLocationAtSplinePoint(int PointIndex, ESplineCoordinateSpace CoordinateSpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(int*)(__InBuffer) = PointIndex;

				*(byte*)(__InBuffer + 4) = (byte)CoordinateSpace;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetLocationAtSplinePoint, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual FVector GetLocationAtSplineInputKey(float InKey, ESplineCoordinateSpace CoordinateSpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(float*)(__InBuffer) = InKey;

				*(byte*)(__InBuffer + 4) = (byte)CoordinateSpace;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetLocationAtSplineInputKey, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual FVector GetLocationAtDistanceAlongSpline(float Distance, ESplineCoordinateSpace CoordinateSpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(float*)(__InBuffer) = Distance;

				*(byte*)(__InBuffer + 4) = (byte)CoordinateSpace;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetLocationAtDistanceAlongSpline, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual void GetLocationAndTangentAtSplinePoint(int PointIndex, ref FVector Location, ref FVector Tangent, ESplineCoordinateSpace CoordinateSpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[21];

				*(int*)(__InBuffer) = PointIndex;

				*(nint*)(__InBuffer + 4) = Location?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 12) = Tangent?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 20) = (byte)CoordinateSpace;

				var __OutBuffer = stackalloc byte[16];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetLocationAndTangentAtSplinePoint, __InBuffer, __OutBuffer);

				Location = *(FVector*)(__OutBuffer);

				Tangent = *(FVector*)(__OutBuffer + 8);

			}
		}

		public virtual void GetLocalLocationAndTangentAtSplinePoint(int PointIndex, ref FVector LocalLocation, ref FVector LocalTangent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(int*)(__InBuffer) = PointIndex;

				*(nint*)(__InBuffer + 4) = LocalLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 12) = LocalTangent?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[16];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetLocalLocationAndTangentAtSplinePoint, __InBuffer, __OutBuffer);

				LocalLocation = *(FVector*)(__OutBuffer);

				LocalTangent = *(FVector*)(__OutBuffer + 8);

			}
		}

		public virtual FVector GetLeaveTangentAtSplinePoint(int PointIndex, ESplineCoordinateSpace CoordinateSpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(int*)(__InBuffer) = PointIndex;

				*(byte*)(__InBuffer + 4) = (byte)CoordinateSpace;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetLeaveTangentAtSplinePoint, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual float GetInputKeyValueAtSplinePoint(int PointIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = PointIndex;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetInputKeyValueAtSplinePoint, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetInputKeyValueAtDistanceAlongSpline(float Distance)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Distance;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetInputKeyValueAtDistanceAlongSpline, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetInputKeyAtDistanceAlongSpline(float Distance)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Distance;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetInputKeyAtDistanceAlongSpline, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetFloatPropertyAtSplinePoint(int Index, FName PropertyName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = Index;

				*(nint*)(__InBuffer + 4) = PropertyName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetFloatPropertyAtSplinePoint, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetFloatPropertyAtSplineInputKey(float InKey, FName PropertyName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(float*)(__InBuffer) = InKey;

				*(nint*)(__InBuffer + 4) = PropertyName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetFloatPropertyAtSplineInputKey, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetDistanceAlongSplineAtSplinePoint(int PointIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = PointIndex;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetDistanceAlongSplineAtSplinePoint, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetDistanceAlongSplineAtSplineInputKey(float InKey)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InKey;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetDistanceAlongSplineAtSplineInputKey, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetDistanceAlongSplineAtLocation(FVector InLocation, ESplineCoordinateSpace CoordinateSpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)CoordinateSpace;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetDistanceAlongSplineAtLocation, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual FVector GetDirectionAtTime(float Time, ESplineCoordinateSpace CoordinateSpace, bool bUseConstantVelocity = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[6];

				*(float*)(__InBuffer) = Time;

				*(byte*)(__InBuffer + 4) = (byte)CoordinateSpace;

				*(bool*)(__InBuffer + 5) = bUseConstantVelocity;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetDirectionAtTime, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual FVector GetDirectionAtSplinePoint(int PointIndex, ESplineCoordinateSpace CoordinateSpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(int*)(__InBuffer) = PointIndex;

				*(byte*)(__InBuffer + 4) = (byte)CoordinateSpace;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetDirectionAtSplinePoint, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual FVector GetDirectionAtSplineInputKey(float InKey, ESplineCoordinateSpace CoordinateSpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(float*)(__InBuffer) = InKey;

				*(byte*)(__InBuffer + 4) = (byte)CoordinateSpace;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetDirectionAtSplineInputKey, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual FVector GetDirectionAtDistanceAlongSpline(float Distance, ESplineCoordinateSpace CoordinateSpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(float*)(__InBuffer) = Distance;

				*(byte*)(__InBuffer + 4) = (byte)CoordinateSpace;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetDirectionAtDistanceAlongSpline, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual FVector GetDefaultUpVector(ESplineCoordinateSpace CoordinateSpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)CoordinateSpace;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetDefaultUpVector, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual FVector GetArriveTangentAtSplinePoint(int PointIndex, ESplineCoordinateSpace CoordinateSpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(int*)(__InBuffer) = PointIndex;

				*(byte*)(__InBuffer + 4) = (byte)CoordinateSpace;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetArriveTangentAtSplinePoint, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual FVector FindUpVectorClosestToWorldLocation(FVector WorldLocation, ESplineCoordinateSpace CoordinateSpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = WorldLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)CoordinateSpace;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __FindUpVectorClosestToWorldLocation, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual FTransform FindTransformClosestToWorldLocation(FVector WorldLocation, ESplineCoordinateSpace CoordinateSpace, bool bUseScale = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = WorldLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)CoordinateSpace;

				*(bool*)(__InBuffer + 9) = bUseScale;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __FindTransformClosestToWorldLocation, __InBuffer, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		public virtual FVector FindTangentClosestToWorldLocation(FVector WorldLocation, ESplineCoordinateSpace CoordinateSpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = WorldLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)CoordinateSpace;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __FindTangentClosestToWorldLocation, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual FVector FindScaleClosestToWorldLocation(FVector WorldLocation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldLocation?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __FindScaleClosestToWorldLocation, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual FRotator FindRotationClosestToWorldLocation(FVector WorldLocation, ESplineCoordinateSpace CoordinateSpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = WorldLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)CoordinateSpace;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __FindRotationClosestToWorldLocation, __InBuffer, __ReturnBuffer);

				return *(FRotator*)__ReturnBuffer;
			}
		}

		public virtual float FindRollClosestToWorldLocation(FVector WorldLocation, ESplineCoordinateSpace CoordinateSpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = WorldLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)CoordinateSpace;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __FindRollClosestToWorldLocation, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual FVector FindRightVectorClosestToWorldLocation(FVector WorldLocation, ESplineCoordinateSpace CoordinateSpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = WorldLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)CoordinateSpace;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __FindRightVectorClosestToWorldLocation, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual FVector FindLocationClosestToWorldLocation(FVector WorldLocation, ESplineCoordinateSpace CoordinateSpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = WorldLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)CoordinateSpace;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __FindLocationClosestToWorldLocation, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual float FindInputKeyClosestToWorldLocation(FVector WorldLocation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldLocation?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __FindInputKeyClosestToWorldLocation, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual FVector FindDirectionClosestToWorldLocation(FVector WorldLocation, ESplineCoordinateSpace CoordinateSpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = WorldLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)CoordinateSpace;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __FindDirectionClosestToWorldLocation, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual bool DivideSplineIntoPolylineRecursiveWithDistances(float StartDistanceAlongSpline, float EndDistanceAlongSpline, ESplineCoordinateSpace CoordinateSpace, float MaxSquareDistanceFromSpline, ref TArray<FVector> OutPoints, ref TArray<double> OutDistancesAlongSpline)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[29];

				*(float*)(__InBuffer) = StartDistanceAlongSpline;

				*(float*)(__InBuffer + 4) = EndDistanceAlongSpline;

				*(byte*)(__InBuffer + 8) = (byte)CoordinateSpace;

				*(float*)(__InBuffer + 9) = MaxSquareDistanceFromSpline;

				*(nint*)(__InBuffer + 13) = OutPoints?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 21) = OutDistancesAlongSpline?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[16];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __DivideSplineIntoPolylineRecursiveWithDistances, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutPoints = *(TArray<FVector>*)(__OutBuffer);

				OutDistancesAlongSpline = *(TArray<double>*)(__OutBuffer + 8);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool DivideSplineIntoPolylineRecursive(float StartDistanceAlongSpline, float EndDistanceAlongSpline, ESplineCoordinateSpace CoordinateSpace, float MaxSquareDistanceFromSpline, ref TArray<FVector> OutPoints)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[21];

				*(float*)(__InBuffer) = StartDistanceAlongSpline;

				*(float*)(__InBuffer + 4) = EndDistanceAlongSpline;

				*(byte*)(__InBuffer + 8) = (byte)CoordinateSpace;

				*(float*)(__InBuffer + 9) = MaxSquareDistanceFromSpline;

				*(nint*)(__InBuffer + 13) = OutPoints?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __DivideSplineIntoPolylineRecursive, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutPoints = *(TArray<FVector>*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool ConvertSplineToPolyLine(ESplineCoordinateSpace CoordinateSpace, float MaxSquareDistanceFromSpline, ref TArray<FVector> OutPoints)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(byte*)(__InBuffer) = (byte)CoordinateSpace;

				*(float*)(__InBuffer + 1) = MaxSquareDistanceFromSpline;

				*(nint*)(__InBuffer + 5) = OutPoints?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __ConvertSplineToPolyLine, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutPoints = *(TArray<FVector>*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool ConvertSplineSegmentToPolyLine(int SplinePointStartIndex, ESplineCoordinateSpace CoordinateSpace, float MaxSquareDistanceFromSpline, ref TArray<FVector> OutPoints)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(int*)(__InBuffer) = SplinePointStartIndex;

				*(byte*)(__InBuffer + 4) = (byte)CoordinateSpace;

				*(float*)(__InBuffer + 5) = MaxSquareDistanceFromSpline;

				*(nint*)(__InBuffer + 9) = OutPoints?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __ConvertSplineSegmentToPolyLine, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutPoints = *(TArray<FVector>*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void ClearSplinePoints(bool bUpdateSpline = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bUpdateSpline;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ClearSplinePoints, __InBuffer);
			}
		}

		public virtual void AddSplineWorldPoint(FVector Position)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Position?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddSplineWorldPoint, __InBuffer);
			}
		}

		public virtual void AddSplinePointAtIndex(FVector Position, int Index, ESplineCoordinateSpace CoordinateSpace, bool bUpdateSpline = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[14];

				*(nint*)(__InBuffer) = Position?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Index;

				*(byte*)(__InBuffer + 12) = (byte)CoordinateSpace;

				*(bool*)(__InBuffer + 13) = bUpdateSpline;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddSplinePointAtIndex, __InBuffer);
			}
		}

		public virtual void AddSplinePoint(FVector Position, ESplineCoordinateSpace CoordinateSpace, bool bUpdateSpline = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = Position?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)CoordinateSpace;

				*(bool*)(__InBuffer + 9) = bUpdateSpline;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddSplinePoint, __InBuffer);
			}
		}

		public virtual void AddSplineLocalPoint(FVector Position)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Position?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddSplineLocalPoint, __InBuffer);
			}
		}

		public virtual void AddPoints(TArray<FSplinePoint> Points, bool bUpdateSpline = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Points?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bUpdateSpline;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddPoints, __InBuffer);
			}
		}

		public virtual void AddPoint(FSplinePoint Point, bool bUpdateSpline = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Point?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bUpdateSpline;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddPoint, __InBuffer);
			}
		}

		private static uint __SplineCurves = 0;

		private static uint __ReparamStepsPerSegment = 0;

		private static uint __Duration = 0;

		private static uint __bStationaryEndpoints = 0;

		private static uint __bSplineHasBeenEdited = 0;

		private static uint __bModifiedByConstructionScript = 0;

		private static uint __bInputSplinePointsToConstructionScript = 0;

		private static uint __bDrawDebug = 0;

		private static uint __bClosedLoop = 0;

		private static uint __bLoopPositionOverride = 0;

		private static uint __LoopPosition = 0;

		private static uint __DefaultUpVector = 0;

		private static uint __EditorUnselectedSplineSegmentColor = 0;

		private static uint __EditorSelectedSplineSegmentColor = 0;

		private static uint __EditorTangentColor = 0;

		private static uint __bAllowDiscontinuousSpline = 0;

		private static uint __bShouldVisualizeScale = 0;

		private static uint __ScaleVisualizationWidth = 0;

		private static uint __UpdateSpline = 0;

		private static uint __SetWorldLocationAtSplinePoint = 0;

		private static uint __SetUpVectorAtSplinePoint = 0;

		private static uint __SetUnselectedSplineSegmentColor = 0;

		private static uint __SetTangentsAtSplinePoint = 0;

		private static uint __SetTangentColor = 0;

		private static uint __SetTangentAtSplinePoint = 0;

		private static uint __SetSplineWorldPoints = 0;

		private static uint __SetSplinePointType = 0;

		private static uint __SetSplinePoints = 0;

		private static uint __SetSplineLocalPoints = 0;

		private static uint __SetSelectedSplineSegmentColor = 0;

		private static uint __SetScaleAtSplinePoint = 0;

		private static uint __SetRotationAtSplinePoint = 0;

		private static uint __SetLocationAtSplinePoint = 0;

		private static uint __SetDrawDebug = 0;

		private static uint __SetDefaultUpVector = 0;

		private static uint __SetClosedLoopAtPosition = 0;

		private static uint __SetClosedLoop = 0;

		private static uint __RemoveSplinePoint = 0;

		private static uint __IsClosedLoop = 0;

		private static uint __GetWorldTangentAtDistanceAlongSpline = 0;

		private static uint __GetWorldRotationAtTime = 0;

		private static uint __GetWorldRotationAtDistanceAlongSpline = 0;

		private static uint __GetWorldLocationAtTime = 0;

		private static uint __GetWorldLocationAtSplinePoint = 0;

		private static uint __GetWorldLocationAtDistanceAlongSpline = 0;

		private static uint __GetWorldDirectionAtTime = 0;

		private static uint __GetWorldDirectionAtDistanceAlongSpline = 0;

		private static uint __GetVectorPropertyAtSplinePoint = 0;

		private static uint __GetVectorPropertyAtSplineInputKey = 0;

		private static uint __GetUpVectorAtTime = 0;

		private static uint __GetUpVectorAtSplinePoint = 0;

		private static uint __GetUpVectorAtSplineInputKey = 0;

		private static uint __GetUpVectorAtDistanceAlongSpline = 0;

		private static uint __GetTransformAtTime = 0;

		private static uint __GetTransformAtSplinePoint = 0;

		private static uint __GetTransformAtSplineInputKey = 0;

		private static uint __GetTransformAtDistanceAlongSpline = 0;

		private static uint __GetTimeAtDistanceAlongSpline = 0;

		private static uint __GetTangentAtTime = 0;

		private static uint __GetTangentAtSplinePoint = 0;

		private static uint __GetTangentAtSplineInputKey = 0;

		private static uint __GetTangentAtDistanceAlongSpline = 0;

		private static uint __GetSplinePointType = 0;

		private static uint __GetSplinePointAt = 0;

		private static uint __GetSplineLength = 0;

		private static uint __GetScaleAtTime = 0;

		private static uint __GetScaleAtSplinePoint = 0;

		private static uint __GetScaleAtSplineInputKey = 0;

		private static uint __GetScaleAtDistanceAlongSpline = 0;

		private static uint __GetRotationAtTime = 0;

		private static uint __GetRotationAtSplinePoint = 0;

		private static uint __GetRotationAtSplineInputKey = 0;

		private static uint __GetRotationAtDistanceAlongSpline = 0;

		private static uint __GetRollAtTime = 0;

		private static uint __GetRollAtSplinePoint = 0;

		private static uint __GetRollAtSplineInputKey = 0;

		private static uint __GetRollAtDistanceAlongSpline = 0;

		private static uint __GetRightVectorAtTime = 0;

		private static uint __GetRightVectorAtSplinePoint = 0;

		private static uint __GetRightVectorAtSplineInputKey = 0;

		private static uint __GetRightVectorAtDistanceAlongSpline = 0;

		private static uint __GetNumberOfSplineSegments = 0;

		private static uint __GetNumberOfSplinePoints = 0;

		private static uint __GetLocationAtTime = 0;

		private static uint __GetLocationAtSplinePoint = 0;

		private static uint __GetLocationAtSplineInputKey = 0;

		private static uint __GetLocationAtDistanceAlongSpline = 0;

		private static uint __GetLocationAndTangentAtSplinePoint = 0;

		private static uint __GetLocalLocationAndTangentAtSplinePoint = 0;

		private static uint __GetLeaveTangentAtSplinePoint = 0;

		private static uint __GetInputKeyValueAtSplinePoint = 0;

		private static uint __GetInputKeyValueAtDistanceAlongSpline = 0;

		private static uint __GetInputKeyAtDistanceAlongSpline = 0;

		private static uint __GetFloatPropertyAtSplinePoint = 0;

		private static uint __GetFloatPropertyAtSplineInputKey = 0;

		private static uint __GetDistanceAlongSplineAtSplinePoint = 0;

		private static uint __GetDistanceAlongSplineAtSplineInputKey = 0;

		private static uint __GetDistanceAlongSplineAtLocation = 0;

		private static uint __GetDirectionAtTime = 0;

		private static uint __GetDirectionAtSplinePoint = 0;

		private static uint __GetDirectionAtSplineInputKey = 0;

		private static uint __GetDirectionAtDistanceAlongSpline = 0;

		private static uint __GetDefaultUpVector = 0;

		private static uint __GetArriveTangentAtSplinePoint = 0;

		private static uint __FindUpVectorClosestToWorldLocation = 0;

		private static uint __FindTransformClosestToWorldLocation = 0;

		private static uint __FindTangentClosestToWorldLocation = 0;

		private static uint __FindScaleClosestToWorldLocation = 0;

		private static uint __FindRotationClosestToWorldLocation = 0;

		private static uint __FindRollClosestToWorldLocation = 0;

		private static uint __FindRightVectorClosestToWorldLocation = 0;

		private static uint __FindLocationClosestToWorldLocation = 0;

		private static uint __FindInputKeyClosestToWorldLocation = 0;

		private static uint __FindDirectionClosestToWorldLocation = 0;

		private static uint __DivideSplineIntoPolylineRecursiveWithDistances = 0;

		private static uint __DivideSplineIntoPolylineRecursive = 0;

		private static uint __ConvertSplineToPolyLine = 0;

		private static uint __ConvertSplineSegmentToPolyLine = 0;

		private static uint __ClearSplinePoints = 0;

		private static uint __AddSplineWorldPoint = 0;

		private static uint __AddSplinePointAtIndex = 0;

		private static uint __AddSplinePoint = 0;

		private static uint __AddSplineLocalPoint = 0;

		private static uint __AddPoints = 0;

		private static uint __AddPoint = 0;
	}
}