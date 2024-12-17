using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SplineMeshComponent")]
	public partial class USplineMeshComponent : UStaticMeshComponent, IStaticClass, IInterface_CollisionDataProvider
	{
		public FSplineMeshParams SplineParams
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SplineParams, __ReturnBuffer);

					return *(FSplineMeshParams*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SplineParams, __InBuffer);
				}
			}
		}

		public FVector SplineUpDir
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SplineUpDir, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SplineUpDir, __InBuffer);
				}
			}
		}

		public float SplineBoundaryMin
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SplineBoundaryMin, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SplineBoundaryMin, __InBuffer);
				}
			}
		}

		public FGuid CachedMeshBodySetupGuid
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CachedMeshBodySetupGuid, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CachedMeshBodySetupGuid, __InBuffer);
				}
			}
		}

		public UBodySetup BodySetup
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BodySetup, __ReturnBuffer);

					return *(UBodySetup*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BodySetup, __InBuffer);
				}
			}
		}

		public float SplineBoundaryMax
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SplineBoundaryMax, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SplineBoundaryMax, __InBuffer);
				}
			}
		}

		public bool bAllowSplineEditingPerInstance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAllowSplineEditingPerInstance, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAllowSplineEditingPerInstance, __InBuffer);
				}
			}
		}

		public bool bSmoothInterpRollScale
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bSmoothInterpRollScale, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bSmoothInterpRollScale, __InBuffer);
				}
			}
		}

		public bool bMeshDirty
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bMeshDirty, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bMeshDirty, __InBuffer);
				}
			}
		}

		public ESplineMeshAxis ForwardAxis
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ForwardAxis, __ReturnBuffer);

					return *(ESplineMeshAxis*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ForwardAxis, __InBuffer);
				}
			}
		}

		public float VirtualTextureMainPassMaxDrawDistance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __VirtualTextureMainPassMaxDrawDistance, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __VirtualTextureMainPassMaxDrawDistance, __InBuffer);
				}
			}
		}

		public bool bSelected
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bSelected, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bSelected, __InBuffer);
				}
			}
		}

		public bool bNeverNeedsCookedCollisionData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bNeverNeedsCookedCollisionData, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bNeverNeedsCookedCollisionData, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.SplineMeshComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="EntryPoint">
		/// The entry point to start code execution at.
		/// </param>
		public override void ExecuteUbergraph(int EntryPoint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = EntryPoint;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ExecuteUbergraph, __InBuffer);
			}
		}

		public virtual void UpdateMesh()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __UpdateMesh);
			}
		}

		public virtual void SetStartTangent(FVector StartTangent, bool bUpdateMesh = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = StartTangent?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bUpdateMesh;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetStartTangent, __InBuffer);
			}
		}

		public virtual void SetStartScale(FVector2D StartScale = null, bool bUpdateMesh = true)
		{
			unsafe
			{
				StartScale ??= new FVector2D(1.000000, 1.000000);

				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = StartScale?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bUpdateMesh;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetStartScale, __InBuffer);
			}
		}

		public virtual void SetStartRollDegrees(float StartRollDegrees, bool bUpdateMesh = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(float*)(__InBuffer) = StartRollDegrees;

				*(bool*)(__InBuffer + 4) = bUpdateMesh;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetStartRollDegrees, __InBuffer);
			}
		}

		public virtual void SetStartRoll(float StartRoll, bool bUpdateMesh = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(float*)(__InBuffer) = StartRoll;

				*(bool*)(__InBuffer + 4) = bUpdateMesh;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetStartRoll, __InBuffer);
			}
		}

		public virtual void SetStartPosition(FVector StartPos, bool bUpdateMesh = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = StartPos?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bUpdateMesh;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetStartPosition, __InBuffer);
			}
		}

		public virtual void SetStartOffset(FVector2D StartOffset, bool bUpdateMesh = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = StartOffset?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bUpdateMesh;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetStartOffset, __InBuffer);
			}
		}

		public virtual void SetStartAndEnd(FVector StartPos, FVector StartTangent, FVector EndPos, FVector EndTangent, bool bUpdateMesh = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[33];

				*(nint*)(__InBuffer) = StartPos?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = StartTangent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = EndPos?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = EndTangent?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 32) = bUpdateMesh;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetStartAndEnd, __InBuffer);
			}
		}

		public virtual void SetSplineUpDir(FVector InSplineUpDir, bool bUpdateMesh = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InSplineUpDir?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bUpdateMesh;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSplineUpDir, __InBuffer);
			}
		}

		public virtual void SetForwardAxis(ESplineMeshAxis InForwardAxis, bool bUpdateMesh = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[2];

				*(byte*)(__InBuffer) = (byte)InForwardAxis;

				*(bool*)(__InBuffer + 1) = bUpdateMesh;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetForwardAxis, __InBuffer);
			}
		}

		public virtual void SetEndTangent(FVector EndTangent, bool bUpdateMesh = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = EndTangent?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bUpdateMesh;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetEndTangent, __InBuffer);
			}
		}

		public virtual void SetEndScale(FVector2D EndScale = null, bool bUpdateMesh = true)
		{
			unsafe
			{
				EndScale ??= new FVector2D(1.000000, 1.000000);

				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = EndScale?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bUpdateMesh;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetEndScale, __InBuffer);
			}
		}

		public virtual void SetEndRollDegrees(float EndRollDegrees, bool bUpdateMesh = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(float*)(__InBuffer) = EndRollDegrees;

				*(bool*)(__InBuffer + 4) = bUpdateMesh;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetEndRollDegrees, __InBuffer);
			}
		}

		public virtual void SetEndRoll(float EndRoll, bool bUpdateMesh = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(float*)(__InBuffer) = EndRoll;

				*(bool*)(__InBuffer + 4) = bUpdateMesh;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetEndRoll, __InBuffer);
			}
		}

		public virtual void SetEndPosition(FVector EndPos, bool bUpdateMesh = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = EndPos?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bUpdateMesh;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetEndPosition, __InBuffer);
			}
		}

		public virtual void SetEndOffset(FVector2D EndOffset, bool bUpdateMesh = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = EndOffset?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bUpdateMesh;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetEndOffset, __InBuffer);
			}
		}

		public virtual void SetBoundaryMin(float InBoundaryMin, bool bUpdateMesh = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(float*)(__InBuffer) = InBoundaryMin;

				*(bool*)(__InBuffer + 4) = bUpdateMesh;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetBoundaryMin, __InBuffer);
			}
		}

		public virtual void SetBoundaryMax(float InBoundaryMax, bool bUpdateMesh = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(float*)(__InBuffer) = InBoundaryMax;

				*(bool*)(__InBuffer + 4) = bUpdateMesh;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetBoundaryMax, __InBuffer);
			}
		}

		public virtual FVector GetStartTangent()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetStartTangent, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual FVector2D GetStartScale()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetStartScale, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		public virtual float GetStartRoll()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetStartRoll, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual FVector GetStartPosition()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetStartPosition, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual FVector2D GetStartOffset()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetStartOffset, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		public virtual FVector GetSplineUpDir()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetSplineUpDir, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual ESplineMeshAxis GetForwardAxis()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetForwardAxis, __ReturnBuffer);

				return *(ESplineMeshAxis*)__ReturnBuffer;
			}
		}

		public virtual FVector GetEndTangent()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetEndTangent, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual FVector2D GetEndScale()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetEndScale, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		public virtual float GetEndRoll()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetEndRoll, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual FVector GetEndPosition()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetEndPosition, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual FVector2D GetEndOffset()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetEndOffset, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		public virtual float GetBoundaryMin()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetBoundaryMin, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetBoundaryMax()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetBoundaryMax, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		private static uint __SplineParams = 0;

		private static uint __SplineUpDir = 0;

		private static uint __SplineBoundaryMin = 0;

		private static uint __CachedMeshBodySetupGuid = 0;

		private static uint __BodySetup = 0;

		private static uint __SplineBoundaryMax = 0;

		private static uint __bAllowSplineEditingPerInstance = 0;

		private static uint __bSmoothInterpRollScale = 0;

		private static uint __bMeshDirty = 0;

		private static uint __ForwardAxis = 0;

		private static uint __VirtualTextureMainPassMaxDrawDistance = 0;

		private static uint __bSelected = 0;

		private static uint __bNeverNeedsCookedCollisionData = 0;

		private static uint __ExecuteUbergraph = 0;

		private static uint __UpdateMesh = 0;

		private static uint __SetStartTangent = 0;

		private static uint __SetStartScale = 0;

		private static uint __SetStartRollDegrees = 0;

		private static uint __SetStartRoll = 0;

		private static uint __SetStartPosition = 0;

		private static uint __SetStartOffset = 0;

		private static uint __SetStartAndEnd = 0;

		private static uint __SetSplineUpDir = 0;

		private static uint __SetForwardAxis = 0;

		private static uint __SetEndTangent = 0;

		private static uint __SetEndScale = 0;

		private static uint __SetEndRollDegrees = 0;

		private static uint __SetEndRoll = 0;

		private static uint __SetEndPosition = 0;

		private static uint __SetEndOffset = 0;

		private static uint __SetBoundaryMin = 0;

		private static uint __SetBoundaryMax = 0;

		private static uint __GetStartTangent = 0;

		private static uint __GetStartScale = 0;

		private static uint __GetStartRoll = 0;

		private static uint __GetStartPosition = 0;

		private static uint __GetStartOffset = 0;

		private static uint __GetSplineUpDir = 0;

		private static uint __GetForwardAxis = 0;

		private static uint __GetEndTangent = 0;

		private static uint __GetEndScale = 0;

		private static uint __GetEndRoll = 0;

		private static uint __GetEndPosition = 0;

		private static uint __GetEndOffset = 0;

		private static uint __GetBoundaryMin = 0;

		private static uint __GetBoundaryMax = 0;
	}
}