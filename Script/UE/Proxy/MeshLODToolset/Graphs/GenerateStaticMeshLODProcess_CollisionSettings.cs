using Script.CoreUObject;
using Script.Library;

namespace Script.MeshLODToolset
{
	[PathName("/Script/MeshLODToolset.GenerateStaticMeshLODProcess_CollisionSettings")]
	public partial class FGenerateStaticMeshLODProcess_CollisionSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MeshLODToolset.GenerateStaticMeshLODProcess_CollisionSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGenerateStaticMeshLODProcess_CollisionSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FGenerateStaticMeshLODProcess_CollisionSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FGenerateStaticMeshLODProcess_CollisionSettings A, FGenerateStaticMeshLODProcess_CollisionSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGenerateStaticMeshLODProcess_CollisionSettings A, FGenerateStaticMeshLODProcess_CollisionSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGenerateStaticMeshLODProcess_CollisionSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName CollisionGroupLayerName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CollisionGroupLayerName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CollisionGroupLayerName, __InBuffer);
				}
			}
		}

		public EGenerateStaticMeshLODSimpleCollisionGeometryType CollisionType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CollisionType, __ReturnBuffer);

					return *(EGenerateStaticMeshLODSimpleCollisionGeometryType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CollisionType, __InBuffer);
				}
			}
		}

		public int ConvexTriangleCount
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ConvexTriangleCount, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ConvexTriangleCount, __InBuffer);
				}
			}
		}

		public bool bPrefilterVertices
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bPrefilterVertices, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bPrefilterVertices, __InBuffer);
				}
			}
		}

		public int PrefilterGridResolution
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PrefilterGridResolution, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PrefilterGridResolution, __InBuffer);
				}
			}
		}

		public bool bSimplifyPolygons
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bSimplifyPolygons, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bSimplifyPolygons, __InBuffer);
				}
			}
		}

		public float HullTolerance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __HullTolerance, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __HullTolerance, __InBuffer);
				}
			}
		}

		public EGenerateStaticMeshLODProjectedHullAxisMode SweepAxis
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SweepAxis, __ReturnBuffer);

					return *(EGenerateStaticMeshLODProjectedHullAxisMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SweepAxis, __InBuffer);
				}
			}
		}

		private static uint __CollisionGroupLayerName = 0;

		private static uint __CollisionType = 0;

		private static uint __ConvexTriangleCount = 0;

		private static uint __bPrefilterVertices = 0;

		private static uint __PrefilterGridResolution = 0;

		private static uint __bSimplifyPolygons = 0;

		private static uint __HullTolerance = 0;

		private static uint __SweepAxis = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}