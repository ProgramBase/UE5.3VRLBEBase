using Script.CoreUObject;
using Script.Library;

namespace Script.MeshDescription
{
	[PathName("/Script/MeshDescription.MeshDescriptionBase")]
	public partial class UMeshDescriptionBase : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshDescription.MeshDescriptionBase");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetVertexPosition(FVertexID VertexID, FVector Position)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = VertexID?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Position?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetVertexPosition, __InBuffer);
			}
		}

		public virtual void SetPolygonVertexInstances(FPolygonID PolygonID, TArray<FVertexInstanceID> VertexInstanceIDs)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = PolygonID?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = VertexInstanceIDs?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPolygonVertexInstances, __InBuffer);
			}
		}

		public virtual void SetPolygonPolygonGroup(FPolygonID PolygonID, FPolygonGroupID PolygonGroupID)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = PolygonID?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PolygonGroupID?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPolygonPolygonGroup, __InBuffer);
			}
		}

		public virtual void ReversePolygonFacing(FPolygonID PolygonID)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PolygonID?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ReversePolygonFacing, __InBuffer);
			}
		}

		public virtual void ReserveNewVertices(int NumberOfNewVertices)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = NumberOfNewVertices;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ReserveNewVertices, __InBuffer);
			}
		}

		public virtual void ReserveNewVertexInstances(int NumberOfNewVertexInstances)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = NumberOfNewVertexInstances;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ReserveNewVertexInstances, __InBuffer);
			}
		}

		public virtual void ReserveNewTriangles(int NumberOfNewTriangles)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = NumberOfNewTriangles;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ReserveNewTriangles, __InBuffer);
			}
		}

		public virtual void ReserveNewPolygons(int NumberOfNewPolygons)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = NumberOfNewPolygons;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ReserveNewPolygons, __InBuffer);
			}
		}

		public virtual void ReserveNewPolygonGroups(int NumberOfNewPolygonGroups)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = NumberOfNewPolygonGroups;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ReserveNewPolygonGroups, __InBuffer);
			}
		}

		public virtual void ReserveNewEdges(int NumberOfNewEdges)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = NumberOfNewEdges;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ReserveNewEdges, __InBuffer);
			}
		}

		public virtual bool IsVertexValid(FVertexID VertexID)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = VertexID?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsVertexValid, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsVertexOrphaned(FVertexID VertexID)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = VertexID?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsVertexOrphaned, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsVertexInstanceValid(FVertexInstanceID VertexInstanceID)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = VertexInstanceID?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsVertexInstanceValid, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsTriangleValid(FTriangleID TriangleID)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = TriangleID?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsTriangleValid, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsTrianglePartOfNgon(FTriangleID TriangleID)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = TriangleID?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsTrianglePartOfNgon, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsPolygonValid(FPolygonID PolygonID)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PolygonID?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsPolygonValid, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsPolygonGroupValid(FPolygonGroupID PolygonGroupID)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PolygonGroupID?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsPolygonGroupValid, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsEmpty()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsEmpty, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsEdgeValid(FEdgeID EdgeID)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = EdgeID?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsEdgeValid, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsEdgeInternalToPolygon(FEdgeID EdgeID, FPolygonID PolygonID)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = EdgeID?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PolygonID?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsEdgeInternalToPolygon, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsEdgeInternal(FEdgeID EdgeID)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = EdgeID?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsEdgeInternal, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void GetVertexVertexInstances(FVertexID VertexID, ref TArray<FVertexInstanceID> OutVertexInstanceIDs)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = VertexID?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutVertexInstanceIDs?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetVertexVertexInstances, __InBuffer, __OutBuffer);

				OutVertexInstanceIDs = *(TArray<FVertexInstanceID>*)(__OutBuffer);

			}
		}

		public virtual FVector GetVertexPosition(FVertexID VertexID)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = VertexID?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetVertexPosition, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual FEdgeID GetVertexPairEdge(FVertexID VertexID0, FVertexID VertexID1)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = VertexID0?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = VertexID1?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetVertexPairEdge, __InBuffer, __ReturnBuffer);

				return *(FEdgeID*)__ReturnBuffer;
			}
		}

		public virtual FVertexID GetVertexInstanceVertex(FVertexInstanceID VertexInstanceID)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = VertexInstanceID?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetVertexInstanceVertex, __InBuffer, __ReturnBuffer);

				return *(FVertexID*)__ReturnBuffer;
			}
		}

		public virtual FEdgeID GetVertexInstancePairEdge(FVertexInstanceID VertexInstanceID0, FVertexInstanceID VertexInstanceID1)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = VertexInstanceID0?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = VertexInstanceID1?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetVertexInstancePairEdge, __InBuffer, __ReturnBuffer);

				return *(FEdgeID*)__ReturnBuffer;
			}
		}

		public virtual FVertexInstanceID GetVertexInstanceForTriangleVertex(FTriangleID TriangleID, FVertexID VertexID)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = TriangleID?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = VertexID?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetVertexInstanceForTriangleVertex, __InBuffer, __ReturnBuffer);

				return *(FVertexInstanceID*)__ReturnBuffer;
			}
		}

		public virtual FVertexInstanceID GetVertexInstanceForPolygonVertex(FPolygonID PolygonID, FVertexID VertexID)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = PolygonID?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = VertexID?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetVertexInstanceForPolygonVertex, __InBuffer, __ReturnBuffer);

				return *(FVertexInstanceID*)__ReturnBuffer;
			}
		}

		public virtual int GetVertexInstanceCount()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetVertexInstanceCount, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual void GetVertexInstanceConnectedTriangles(FVertexInstanceID VertexInstanceID, ref TArray<FTriangleID> OutConnectedTriangleIDs)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = VertexInstanceID?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutConnectedTriangleIDs?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetVertexInstanceConnectedTriangles, __InBuffer, __OutBuffer);

				OutConnectedTriangleIDs = *(TArray<FTriangleID>*)(__OutBuffer);

			}
		}

		public virtual void GetVertexInstanceConnectedPolygons(FVertexInstanceID VertexInstanceID, ref TArray<FPolygonID> OutConnectedPolygonIDs)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = VertexInstanceID?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutConnectedPolygonIDs?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetVertexInstanceConnectedPolygons, __InBuffer, __OutBuffer);

				OutConnectedPolygonIDs = *(TArray<FPolygonID>*)(__OutBuffer);

			}
		}

		public virtual int GetVertexCount()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetVertexCount, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual void GetVertexConnectedTriangles(FVertexID VertexID, ref TArray<FTriangleID> OutConnectedTriangleIDs)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = VertexID?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutConnectedTriangleIDs?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetVertexConnectedTriangles, __InBuffer, __OutBuffer);

				OutConnectedTriangleIDs = *(TArray<FTriangleID>*)(__OutBuffer);

			}
		}

		public virtual void GetVertexConnectedPolygons(FVertexID VertexID, ref TArray<FPolygonID> OutConnectedPolygonIDs)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = VertexID?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutConnectedPolygonIDs?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetVertexConnectedPolygons, __InBuffer, __OutBuffer);

				OutConnectedPolygonIDs = *(TArray<FPolygonID>*)(__OutBuffer);

			}
		}

		public virtual void GetVertexConnectedEdges(FVertexID VertexID, ref TArray<FEdgeID> OutEdgeIDs)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = VertexID?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutEdgeIDs?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetVertexConnectedEdges, __InBuffer, __OutBuffer);

				OutEdgeIDs = *(TArray<FEdgeID>*)(__OutBuffer);

			}
		}

		public virtual void GetVertexAdjacentVertices(FVertexID VertexID, ref TArray<FVertexID> OutAdjacentVertexIDs)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = VertexID?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutAdjacentVertexIDs?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetVertexAdjacentVertices, __InBuffer, __OutBuffer);

				OutAdjacentVertexIDs = *(TArray<FVertexID>*)(__OutBuffer);

			}
		}

		public virtual void GetTriangleVertices(FTriangleID TriangleID, ref TArray<FVertexID> OutVertexIDs)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = TriangleID?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutVertexIDs?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetTriangleVertices, __InBuffer, __OutBuffer);

				OutVertexIDs = *(TArray<FVertexID>*)(__OutBuffer);

			}
		}

		public virtual void GetTriangleVertexInstances(FTriangleID TriangleID, ref TArray<FVertexInstanceID> OutVertexInstanceIDs)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = TriangleID?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutVertexInstanceIDs?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetTriangleVertexInstances, __InBuffer, __OutBuffer);

				OutVertexInstanceIDs = *(TArray<FVertexInstanceID>*)(__OutBuffer);

			}
		}

		public virtual FVertexInstanceID GetTriangleVertexInstance(FTriangleID TriangleID, int Index)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = TriangleID?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Index;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetTriangleVertexInstance, __InBuffer, __ReturnBuffer);

				return *(FVertexInstanceID*)__ReturnBuffer;
			}
		}

		public virtual FPolygonGroupID GetTrianglePolygonGroup(FTriangleID TriangleID)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = TriangleID?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetTrianglePolygonGroup, __InBuffer, __ReturnBuffer);

				return *(FPolygonGroupID*)__ReturnBuffer;
			}
		}

		public virtual FPolygonID GetTrianglePolygon(FTriangleID TriangleID)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = TriangleID?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetTrianglePolygon, __InBuffer, __ReturnBuffer);

				return *(FPolygonID*)__ReturnBuffer;
			}
		}

		public virtual void GetTriangleEdges(FTriangleID TriangleID, ref TArray<FEdgeID> OutEdgeIDs)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = TriangleID?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutEdgeIDs?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetTriangleEdges, __InBuffer, __OutBuffer);

				OutEdgeIDs = *(TArray<FEdgeID>*)(__OutBuffer);

			}
		}

		public virtual int GetTriangleCount()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetTriangleCount, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual void GetTriangleAdjacentTriangles(FTriangleID TriangleID, ref TArray<FTriangleID> OutTriangleIDs)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = TriangleID?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutTriangleIDs?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetTriangleAdjacentTriangles, __InBuffer, __OutBuffer);

				OutTriangleIDs = *(TArray<FTriangleID>*)(__OutBuffer);

			}
		}

		public virtual void GetPolygonVertices(FPolygonID PolygonID, ref TArray<FVertexID> OutVertexIDs)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = PolygonID?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutVertexIDs?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetPolygonVertices, __InBuffer, __OutBuffer);

				OutVertexIDs = *(TArray<FVertexID>*)(__OutBuffer);

			}
		}

		public virtual void GetPolygonVertexInstances(FPolygonID PolygonID, ref TArray<FVertexInstanceID> OutVertexInstanceIDs)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = PolygonID?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutVertexInstanceIDs?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetPolygonVertexInstances, __InBuffer, __OutBuffer);

				OutVertexInstanceIDs = *(TArray<FVertexInstanceID>*)(__OutBuffer);

			}
		}

		public virtual void GetPolygonTriangles(FPolygonID PolygonID, ref TArray<FTriangleID> OutTriangleIDs)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = PolygonID?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutTriangleIDs?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetPolygonTriangles, __InBuffer, __OutBuffer);

				OutTriangleIDs = *(TArray<FTriangleID>*)(__OutBuffer);

			}
		}

		public virtual FPolygonGroupID GetPolygonPolygonGroup(FPolygonID PolygonID)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PolygonID?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetPolygonPolygonGroup, __InBuffer, __ReturnBuffer);

				return *(FPolygonGroupID*)__ReturnBuffer;
			}
		}

		public virtual void GetPolygonPerimeterEdges(FPolygonID PolygonID, ref TArray<FEdgeID> OutEdgeIDs)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = PolygonID?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutEdgeIDs?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetPolygonPerimeterEdges, __InBuffer, __OutBuffer);

				OutEdgeIDs = *(TArray<FEdgeID>*)(__OutBuffer);

			}
		}

		public virtual void GetPolygonInternalEdges(FPolygonID PolygonID, ref TArray<FEdgeID> OutEdgeIDs)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = PolygonID?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutEdgeIDs?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetPolygonInternalEdges, __InBuffer, __OutBuffer);

				OutEdgeIDs = *(TArray<FEdgeID>*)(__OutBuffer);

			}
		}

		public virtual void GetPolygonGroupPolygons(FPolygonGroupID PolygonGroupID, ref TArray<FPolygonID> OutPolygonIDs)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = PolygonGroupID?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutPolygonIDs?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetPolygonGroupPolygons, __InBuffer, __OutBuffer);

				OutPolygonIDs = *(TArray<FPolygonID>*)(__OutBuffer);

			}
		}

		public virtual int GetPolygonGroupCount()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetPolygonGroupCount, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual int GetPolygonCount()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetPolygonCount, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual void GetPolygonAdjacentPolygons(FPolygonID PolygonID, ref TArray<FPolygonID> OutPolygonIDs)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = PolygonID?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutPolygonIDs?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetPolygonAdjacentPolygons, __InBuffer, __OutBuffer);

				OutPolygonIDs = *(TArray<FPolygonID>*)(__OutBuffer);

			}
		}

		public virtual int GetNumVertexVertexInstances(FVertexID VertexID)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = VertexID?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetNumVertexVertexInstances, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual int GetNumVertexInstanceConnectedTriangles(FVertexInstanceID VertexInstanceID)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = VertexInstanceID?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetNumVertexInstanceConnectedTriangles, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual int GetNumVertexInstanceConnectedPolygons(FVertexInstanceID VertexInstanceID)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = VertexInstanceID?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetNumVertexInstanceConnectedPolygons, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual int GetNumVertexConnectedTriangles(FVertexID VertexID)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = VertexID?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetNumVertexConnectedTriangles, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual int GetNumVertexConnectedPolygons(FVertexID VertexID)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = VertexID?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetNumVertexConnectedPolygons, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual int GetNumVertexConnectedEdges(FVertexID VertexID)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = VertexID?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetNumVertexConnectedEdges, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual int GetNumPolygonVertices(FPolygonID PolygonID)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PolygonID?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetNumPolygonVertices, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual int GetNumPolygonTriangles(FPolygonID PolygonID)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PolygonID?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetNumPolygonTriangles, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual int GetNumPolygonInternalEdges(FPolygonID PolygonID)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PolygonID?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetNumPolygonInternalEdges, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual int GetNumPolygonGroupPolygons(FPolygonGroupID PolygonGroupID)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PolygonGroupID?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetNumPolygonGroupPolygons, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual int GetNumEdgeConnectedTriangles(FEdgeID EdgeID)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = EdgeID?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetNumEdgeConnectedTriangles, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual int GetNumEdgeConnectedPolygons(FEdgeID EdgeID)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = EdgeID?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetNumEdgeConnectedPolygons, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual void GetEdgeVertices(FEdgeID EdgeID, ref TArray<FVertexID> OutVertexIDs)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = EdgeID?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutVertexIDs?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetEdgeVertices, __InBuffer, __OutBuffer);

				OutVertexIDs = *(TArray<FVertexID>*)(__OutBuffer);

			}
		}

		public virtual FVertexID GetEdgeVertex(FEdgeID EdgeID, int VertexNumber)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = EdgeID?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = VertexNumber;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetEdgeVertex, __InBuffer, __ReturnBuffer);

				return *(FVertexID*)__ReturnBuffer;
			}
		}

		public virtual int GetEdgeCount()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetEdgeCount, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual void GetEdgeConnectedTriangles(FEdgeID EdgeID, ref TArray<FTriangleID> OutConnectedTriangleIDs)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = EdgeID?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutConnectedTriangleIDs?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetEdgeConnectedTriangles, __InBuffer, __OutBuffer);

				OutConnectedTriangleIDs = *(TArray<FTriangleID>*)(__OutBuffer);

			}
		}

		public virtual void GetEdgeConnectedPolygons(FEdgeID EdgeID, ref TArray<FPolygonID> OutConnectedPolygonIDs)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = EdgeID?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutConnectedPolygonIDs?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetEdgeConnectedPolygons, __InBuffer, __OutBuffer);

				OutConnectedPolygonIDs = *(TArray<FPolygonID>*)(__OutBuffer);

			}
		}

		public virtual void Empty()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Empty);
			}
		}

		public virtual void DeleteVertexInstance(FVertexInstanceID VertexInstanceID, ref TArray<FVertexID> OrphanedVertices)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = VertexInstanceID?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OrphanedVertices?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __DeleteVertexInstance, __InBuffer, __OutBuffer);

				OrphanedVertices = *(TArray<FVertexID>*)(__OutBuffer);

			}
		}

		public virtual void DeleteVertex(FVertexID VertexID)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = VertexID?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __DeleteVertex, __InBuffer);
			}
		}

		public virtual void DeleteTriangle(FTriangleID TriangleID, ref TArray<FEdgeID> OrphanedEdges, ref TArray<FVertexInstanceID> OrphanedVertexInstances, ref TArray<FPolygonGroupID> OrphanedPolygonGroupsPtr)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = TriangleID?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OrphanedEdges?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OrphanedVertexInstances?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = OrphanedPolygonGroupsPtr?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[24];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __DeleteTriangle, __InBuffer, __OutBuffer);

				OrphanedEdges = *(TArray<FEdgeID>*)(__OutBuffer);

				OrphanedVertexInstances = *(TArray<FVertexInstanceID>*)(__OutBuffer + 8);

				OrphanedPolygonGroupsPtr = *(TArray<FPolygonGroupID>*)(__OutBuffer + 16);

			}
		}

		public virtual void DeletePolygonGroup(FPolygonGroupID PolygonGroupID)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PolygonGroupID?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __DeletePolygonGroup, __InBuffer);
			}
		}

		public virtual void DeletePolygon(FPolygonID PolygonID, ref TArray<FEdgeID> OrphanedEdges, ref TArray<FVertexInstanceID> OrphanedVertexInstances, ref TArray<FPolygonGroupID> OrphanedPolygonGroups)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = PolygonID?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OrphanedEdges?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OrphanedVertexInstances?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = OrphanedPolygonGroups?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[24];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __DeletePolygon, __InBuffer, __OutBuffer);

				OrphanedEdges = *(TArray<FEdgeID>*)(__OutBuffer);

				OrphanedVertexInstances = *(TArray<FVertexInstanceID>*)(__OutBuffer + 8);

				OrphanedPolygonGroups = *(TArray<FPolygonGroupID>*)(__OutBuffer + 16);

			}
		}

		public virtual void DeleteEdge(FEdgeID EdgeID, ref TArray<FVertexID> OrphanedVertices)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = EdgeID?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OrphanedVertices?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __DeleteEdge, __InBuffer, __OutBuffer);

				OrphanedVertices = *(TArray<FVertexID>*)(__OutBuffer);

			}
		}

		public virtual void CreateVertexWithID(FVertexID VertexID)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = VertexID?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __CreateVertexWithID, __InBuffer);
			}
		}

		public virtual void CreateVertexInstanceWithID(FVertexInstanceID VertexInstanceID, FVertexID VertexID)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = VertexInstanceID?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = VertexID?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __CreateVertexInstanceWithID, __InBuffer);
			}
		}

		public virtual FVertexInstanceID CreateVertexInstance(FVertexID VertexID)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = VertexID?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __CreateVertexInstance, __InBuffer, __ReturnBuffer);

				return *(FVertexInstanceID*)__ReturnBuffer;
			}
		}

		public virtual FVertexID CreateVertex()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __CreateVertex, __ReturnBuffer);

				return *(FVertexID*)__ReturnBuffer;
			}
		}

		public virtual void CreateTriangleWithID(FTriangleID TriangleID, FPolygonGroupID PolygonGroupID, TArray<FVertexInstanceID> VertexInstanceIDs, ref TArray<FEdgeID> NewEdgeIDs)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = TriangleID?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PolygonGroupID?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = VertexInstanceIDs?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = NewEdgeIDs?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __CreateTriangleWithID, __InBuffer, __OutBuffer);

				NewEdgeIDs = *(TArray<FEdgeID>*)(__OutBuffer);

			}
		}

		public virtual FTriangleID CreateTriangle(FPolygonGroupID PolygonGroupID, TArray<FVertexInstanceID> VertexInstanceIDs, ref TArray<FEdgeID> NewEdgeIDs)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = PolygonGroupID?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = VertexInstanceIDs?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = NewEdgeIDs?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(GarbageCollectionHandle, __CreateTriangle, __InBuffer, __OutBuffer, __ReturnBuffer);

				NewEdgeIDs = *(TArray<FEdgeID>*)(__OutBuffer);

				return *(FTriangleID*)__ReturnBuffer;
			}
		}

		public virtual void CreatePolygonWithID(FPolygonID PolygonID, FPolygonGroupID PolygonGroupID, ref TArray<FVertexInstanceID> VertexInstanceIDs, ref TArray<FEdgeID> NewEdgeIDs)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = PolygonID?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PolygonGroupID?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = VertexInstanceIDs?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = NewEdgeIDs?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[16];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __CreatePolygonWithID, __InBuffer, __OutBuffer);

				VertexInstanceIDs = *(TArray<FVertexInstanceID>*)(__OutBuffer);

				NewEdgeIDs = *(TArray<FEdgeID>*)(__OutBuffer + 8);

			}
		}

		public virtual void CreatePolygonGroupWithID(FPolygonGroupID PolygonGroupID)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PolygonGroupID?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __CreatePolygonGroupWithID, __InBuffer);
			}
		}

		public virtual FPolygonGroupID CreatePolygonGroup()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __CreatePolygonGroup, __ReturnBuffer);

				return *(FPolygonGroupID*)__ReturnBuffer;
			}
		}

		public virtual FPolygonID CreatePolygon(FPolygonGroupID PolygonGroupID, ref TArray<FVertexInstanceID> VertexInstanceIDs, ref TArray<FEdgeID> NewEdgeIDs)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = PolygonGroupID?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = VertexInstanceIDs?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = NewEdgeIDs?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[16];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(GarbageCollectionHandle, __CreatePolygon, __InBuffer, __OutBuffer, __ReturnBuffer);

				VertexInstanceIDs = *(TArray<FVertexInstanceID>*)(__OutBuffer);

				NewEdgeIDs = *(TArray<FEdgeID>*)(__OutBuffer + 8);

				return *(FPolygonID*)__ReturnBuffer;
			}
		}

		public virtual void CreateEdgeWithID(FEdgeID EdgeID, FVertexID VertexID0, FVertexID VertexID1)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = EdgeID?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = VertexID0?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = VertexID1?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __CreateEdgeWithID, __InBuffer);
			}
		}

		public virtual FEdgeID CreateEdge(FVertexID VertexID0, FVertexID VertexID1)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = VertexID0?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = VertexID1?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __CreateEdge, __InBuffer, __ReturnBuffer);

				return *(FEdgeID*)__ReturnBuffer;
			}
		}

		public virtual void ComputePolygonTriangulation(FPolygonID PolygonID)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PolygonID?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ComputePolygonTriangulation, __InBuffer);
			}
		}

		private static uint __SetVertexPosition = 0;

		private static uint __SetPolygonVertexInstances = 0;

		private static uint __SetPolygonPolygonGroup = 0;

		private static uint __ReversePolygonFacing = 0;

		private static uint __ReserveNewVertices = 0;

		private static uint __ReserveNewVertexInstances = 0;

		private static uint __ReserveNewTriangles = 0;

		private static uint __ReserveNewPolygons = 0;

		private static uint __ReserveNewPolygonGroups = 0;

		private static uint __ReserveNewEdges = 0;

		private static uint __IsVertexValid = 0;

		private static uint __IsVertexOrphaned = 0;

		private static uint __IsVertexInstanceValid = 0;

		private static uint __IsTriangleValid = 0;

		private static uint __IsTrianglePartOfNgon = 0;

		private static uint __IsPolygonValid = 0;

		private static uint __IsPolygonGroupValid = 0;

		private static uint __IsEmpty = 0;

		private static uint __IsEdgeValid = 0;

		private static uint __IsEdgeInternalToPolygon = 0;

		private static uint __IsEdgeInternal = 0;

		private static uint __GetVertexVertexInstances = 0;

		private static uint __GetVertexPosition = 0;

		private static uint __GetVertexPairEdge = 0;

		private static uint __GetVertexInstanceVertex = 0;

		private static uint __GetVertexInstancePairEdge = 0;

		private static uint __GetVertexInstanceForTriangleVertex = 0;

		private static uint __GetVertexInstanceForPolygonVertex = 0;

		private static uint __GetVertexInstanceCount = 0;

		private static uint __GetVertexInstanceConnectedTriangles = 0;

		private static uint __GetVertexInstanceConnectedPolygons = 0;

		private static uint __GetVertexCount = 0;

		private static uint __GetVertexConnectedTriangles = 0;

		private static uint __GetVertexConnectedPolygons = 0;

		private static uint __GetVertexConnectedEdges = 0;

		private static uint __GetVertexAdjacentVertices = 0;

		private static uint __GetTriangleVertices = 0;

		private static uint __GetTriangleVertexInstances = 0;

		private static uint __GetTriangleVertexInstance = 0;

		private static uint __GetTrianglePolygonGroup = 0;

		private static uint __GetTrianglePolygon = 0;

		private static uint __GetTriangleEdges = 0;

		private static uint __GetTriangleCount = 0;

		private static uint __GetTriangleAdjacentTriangles = 0;

		private static uint __GetPolygonVertices = 0;

		private static uint __GetPolygonVertexInstances = 0;

		private static uint __GetPolygonTriangles = 0;

		private static uint __GetPolygonPolygonGroup = 0;

		private static uint __GetPolygonPerimeterEdges = 0;

		private static uint __GetPolygonInternalEdges = 0;

		private static uint __GetPolygonGroupPolygons = 0;

		private static uint __GetPolygonGroupCount = 0;

		private static uint __GetPolygonCount = 0;

		private static uint __GetPolygonAdjacentPolygons = 0;

		private static uint __GetNumVertexVertexInstances = 0;

		private static uint __GetNumVertexInstanceConnectedTriangles = 0;

		private static uint __GetNumVertexInstanceConnectedPolygons = 0;

		private static uint __GetNumVertexConnectedTriangles = 0;

		private static uint __GetNumVertexConnectedPolygons = 0;

		private static uint __GetNumVertexConnectedEdges = 0;

		private static uint __GetNumPolygonVertices = 0;

		private static uint __GetNumPolygonTriangles = 0;

		private static uint __GetNumPolygonInternalEdges = 0;

		private static uint __GetNumPolygonGroupPolygons = 0;

		private static uint __GetNumEdgeConnectedTriangles = 0;

		private static uint __GetNumEdgeConnectedPolygons = 0;

		private static uint __GetEdgeVertices = 0;

		private static uint __GetEdgeVertex = 0;

		private static uint __GetEdgeCount = 0;

		private static uint __GetEdgeConnectedTriangles = 0;

		private static uint __GetEdgeConnectedPolygons = 0;

		private static uint __Empty = 0;

		private static uint __DeleteVertexInstance = 0;

		private static uint __DeleteVertex = 0;

		private static uint __DeleteTriangle = 0;

		private static uint __DeletePolygonGroup = 0;

		private static uint __DeletePolygon = 0;

		private static uint __DeleteEdge = 0;

		private static uint __CreateVertexWithID = 0;

		private static uint __CreateVertexInstanceWithID = 0;

		private static uint __CreateVertexInstance = 0;

		private static uint __CreateVertex = 0;

		private static uint __CreateTriangleWithID = 0;

		private static uint __CreateTriangle = 0;

		private static uint __CreatePolygonWithID = 0;

		private static uint __CreatePolygonGroupWithID = 0;

		private static uint __CreatePolygonGroup = 0;

		private static uint __CreatePolygon = 0;

		private static uint __CreateEdgeWithID = 0;

		private static uint __CreateEdge = 0;

		private static uint __ComputePolygonTriangulation = 0;
	}
}