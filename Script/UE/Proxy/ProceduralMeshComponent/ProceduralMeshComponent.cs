using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.ProceduralMeshComponent
{
	[PathName("/Script/ProceduralMeshComponent.ProceduralMeshComponent")]
	public partial class UProceduralMeshComponent : UMeshComponent, IStaticClass, IInterface_CollisionDataProvider
	{
		public bool bUseComplexAsSimpleCollision
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUseComplexAsSimpleCollision, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUseComplexAsSimpleCollision, __InBuffer);
				}
			}
		}

		public bool bUseAsyncCooking
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUseAsyncCooking, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUseAsyncCooking, __InBuffer);
				}
			}
		}

		public UBodySetup ProcMeshBodySetup
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ProcMeshBodySetup, __ReturnBuffer);

					return *(UBodySetup*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ProcMeshBodySetup, __InBuffer);
				}
			}
		}

		public TArray<FProcMeshSection> ProcMeshSections
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ProcMeshSections, __ReturnBuffer);

					return *(TArray<FProcMeshSection>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ProcMeshSections, __InBuffer);
				}
			}
		}

		public TArray<FKConvexElem> CollisionConvexElems
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CollisionConvexElems, __ReturnBuffer);

					return *(TArray<FKConvexElem>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CollisionConvexElems, __InBuffer);
				}
			}
		}

		public FBoxSphereBounds LocalBounds
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LocalBounds, __ReturnBuffer);

					return *(FBoxSphereBounds*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LocalBounds, __InBuffer);
				}
			}
		}

		public TArray<UBodySetup> AsyncBodySetupQueue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AsyncBodySetupQueue, __ReturnBuffer);

					return *(TArray<UBodySetup>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AsyncBodySetupQueue, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ProceduralMeshComponent.ProceduralMeshComponent");
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

		/// <param name="Vertices">
		/// Vertex buffer of all vertex positions to use for this mesh section.
		/// </param>
		/// <param name="Normals">
		/// Optional array of normal vectors for each vertex. If supplied, must be same length as Vertices array.
		/// </param>
		/// <param name="UV0">
		/// Optional array of texture co-ordinates for each vertex. If supplied, must be same length as Vertices array.
		/// </param>
		/// <param name="VertexColors">
		/// Optional array of colors for each vertex. If supplied, must be same length as Vertices array.
		/// </param>
		/// <param name="Tangents">
		/// Optional array of tangent vector for each vertex. If supplied, must be same length as Vertices array.
		/// </param>
		/// <param name="bSRGBConversion">
		/// Whether to do sRGB conversion when converting FLinearColor to FColor
		/// </param>
		public virtual void UpdateMeshSection_LinearColor(int SectionIndex, TArray<FVector> Vertices, TArray<FVector> Normals, TArray<FVector2D> UV0, TArray<FVector2D> UV1, TArray<FVector2D> UV2, TArray<FVector2D> UV3, TArray<FLinearColor> VertexColors, TArray<FProcMeshTangent> Tangents, bool bSRGBConversion = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[69];

				*(int*)(__InBuffer) = SectionIndex;

				*(nint*)(__InBuffer + 4) = Vertices?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 12) = Normals?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 20) = UV0?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 28) = UV1?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 36) = UV2?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 44) = UV3?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 52) = VertexColors?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 60) = Tangents?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 68) = bSRGBConversion;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __UpdateMeshSection_LinearColor, __InBuffer);
			}
		}

		/// <param name="Vertices">
		/// Vertex buffer of all vertex positions to use for this mesh section.
		/// </param>
		/// <param name="Normals">
		/// Optional array of normal vectors for each vertex. If supplied, must be same length as Vertices array.
		/// </param>
		/// <param name="UV0">
		/// Optional array of texture co-ordinates for each vertex. If supplied, must be same length as Vertices array.
		/// </param>
		/// <param name="VertexColors">
		/// Optional array of colors for each vertex. If supplied, must be same length as Vertices array.
		/// </param>
		/// <param name="Tangents">
		/// Optional array of tangent vector for each vertex. If supplied, must be same length as Vertices array.
		/// </param>
		public virtual void UpdateMeshSection(int SectionIndex, TArray<FVector> Vertices, TArray<FVector> Normals, TArray<FVector2D> UV0, TArray<FColor> VertexColors, TArray<FProcMeshTangent> Tangents)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[44];

				*(int*)(__InBuffer) = SectionIndex;

				*(nint*)(__InBuffer + 4) = Vertices?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 12) = Normals?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 20) = UV0?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 28) = VertexColors?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 36) = Tangents?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __UpdateMeshSection, __InBuffer);
			}
		}

		public virtual void SetMeshSectionVisible(int SectionIndex, bool bNewVisibility)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(int*)(__InBuffer) = SectionIndex;

				*(bool*)(__InBuffer + 4) = bNewVisibility;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetMeshSectionVisible, __InBuffer);
			}
		}

		public virtual bool IsMeshSectionVisible(int SectionIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = SectionIndex;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsMeshSectionVisible, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual int GetNumSections()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetNumSections, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="SectionIndex">
		/// Index of the section to create or replace.
		/// </param>
		/// <param name="Vertices">
		/// Vertex buffer of all vertex positions to use for this mesh section.
		/// </param>
		/// <param name="Triangles">
		/// Index buffer indicating which vertices make up each triangle. Length must be a multiple of 3.
		/// </param>
		/// <param name="Normals">
		/// Optional array of normal vectors for each vertex. If supplied, must be same length as Vertices array.
		/// </param>
		/// <param name="UV0">
		/// Optional array of texture co-ordinates for each vertex. If supplied, must be same length as Vertices array.
		/// </param>
		/// <param name="VertexColors">
		/// Optional array of colors for each vertex. If supplied, must be same length as Vertices array.
		/// </param>
		/// <param name="Tangents">
		/// Optional array of tangent vector for each vertex. If supplied, must be same length as Vertices array.
		/// </param>
		/// <param name="bCreateCollision">
		/// Indicates whether collision should be created for this section. This adds significant cost.
		/// </param>
		/// <param name="bSRGBConversion">
		/// Whether to do sRGB conversion when converting FLinearColor to FColor
		/// </param>
		public virtual void CreateMeshSection_LinearColor(int SectionIndex, TArray<FVector> Vertices, TArray<int> Triangles, TArray<FVector> Normals, TArray<FVector2D> UV0, TArray<FVector2D> UV1, TArray<FVector2D> UV2, TArray<FVector2D> UV3, TArray<FLinearColor> VertexColors, TArray<FProcMeshTangent> Tangents, bool bCreateCollision, bool bSRGBConversion = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[78];

				*(int*)(__InBuffer) = SectionIndex;

				*(nint*)(__InBuffer + 4) = Vertices?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 12) = Triangles?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 20) = Normals?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 28) = UV0?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 36) = UV1?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 44) = UV2?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 52) = UV3?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 60) = VertexColors?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 68) = Tangents?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 76) = bCreateCollision;

				*(bool*)(__InBuffer + 77) = bSRGBConversion;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __CreateMeshSection_LinearColor, __InBuffer);
			}
		}

		/// <param name="SectionIndex">
		/// Index of the section to create or replace.
		/// </param>
		/// <param name="Vertices">
		/// Vertex buffer of all vertex positions to use for this mesh section.
		/// </param>
		/// <param name="Triangles">
		/// Index buffer indicating which vertices make up each triangle. Length must be a multiple of 3.
		/// </param>
		/// <param name="Normals">
		/// Optional array of normal vectors for each vertex. If supplied, must be same length as Vertices array.
		/// </param>
		/// <param name="UV0">
		/// Optional array of texture co-ordinates for each vertex. If supplied, must be same length as Vertices array.
		/// </param>
		/// <param name="VertexColors">
		/// Optional array of colors for each vertex. If supplied, must be same length as Vertices array.
		/// </param>
		/// <param name="Tangents">
		/// Optional array of tangent vector for each vertex. If supplied, must be same length as Vertices array.
		/// </param>
		/// <param name="bCreateCollision">
		/// Indicates whether collision should be created for this section. This adds significant cost.
		/// </param>
		public virtual void CreateMeshSection(int SectionIndex, TArray<FVector> Vertices, TArray<int> Triangles, TArray<FVector> Normals, TArray<FVector2D> UV0, TArray<FColor> VertexColors, TArray<FProcMeshTangent> Tangents, bool bCreateCollision)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[53];

				*(int*)(__InBuffer) = SectionIndex;

				*(nint*)(__InBuffer + 4) = Vertices?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 12) = Triangles?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 20) = Normals?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 28) = UV0?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 36) = VertexColors?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 44) = Tangents?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 52) = bCreateCollision;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __CreateMeshSection, __InBuffer);
			}
		}

		public virtual void ClearMeshSection(int SectionIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = SectionIndex;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ClearMeshSection, __InBuffer);
			}
		}

		public virtual void ClearCollisionConvexMeshes()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ClearCollisionConvexMeshes);
			}
		}

		public virtual void ClearAllMeshSections()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ClearAllMeshSections);
			}
		}

		public virtual void AddCollisionConvexMesh(TArray<FVector> ConvexVerts)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ConvexVerts?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddCollisionConvexMesh, __InBuffer);
			}
		}

		private static uint __bUseComplexAsSimpleCollision = 0;

		private static uint __bUseAsyncCooking = 0;

		private static uint __ProcMeshBodySetup = 0;

		private static uint __ProcMeshSections = 0;

		private static uint __CollisionConvexElems = 0;

		private static uint __LocalBounds = 0;

		private static uint __AsyncBodySetupQueue = 0;

		private static uint __ExecuteUbergraph = 0;

		private static uint __UpdateMeshSection_LinearColor = 0;

		private static uint __UpdateMeshSection = 0;

		private static uint __SetMeshSectionVisible = 0;

		private static uint __IsMeshSectionVisible = 0;

		private static uint __GetNumSections = 0;

		private static uint __CreateMeshSection_LinearColor = 0;

		private static uint __CreateMeshSection = 0;

		private static uint __ClearMeshSection = 0;

		private static uint __ClearCollisionConvexMeshes = 0;

		private static uint __ClearAllMeshSections = 0;

		private static uint __AddCollisionConvexMesh = 0;
	}
}