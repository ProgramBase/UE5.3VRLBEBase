using Script.CoreUObject;
using Script.Library;
using Script.ChaosSolverEngine;

namespace Script.GeometryCollectionEngine
{
	[PathName("/Script/GeometryCollectionEngine.GeometryCollectionDebugDrawActorSelectedRigidBody")]
	public partial class FGeometryCollectionDebugDrawActorSelectedRigidBody : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GeometryCollectionEngine.GeometryCollectionDebugDrawActorSelectedRigidBody");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGeometryCollectionDebugDrawActorSelectedRigidBody() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FGeometryCollectionDebugDrawActorSelectedRigidBody() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FGeometryCollectionDebugDrawActorSelectedRigidBody A, FGeometryCollectionDebugDrawActorSelectedRigidBody B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGeometryCollectionDebugDrawActorSelectedRigidBody A, FGeometryCollectionDebugDrawActorSelectedRigidBody B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGeometryCollectionDebugDrawActorSelectedRigidBody;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int Id
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Id, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Id, __InBuffer);
				}
			}
		}

		public AChaosSolverActor Solver
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Solver, __ReturnBuffer);

					return *(AChaosSolverActor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Solver, __InBuffer);
				}
			}
		}

		public AGeometryCollectionActor GeometryCollection
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __GeometryCollection, __ReturnBuffer);

					return *(AGeometryCollectionActor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __GeometryCollection, __InBuffer);
				}
			}
		}

		private static uint __Id = 0;

		private static uint __Solver = 0;

		private static uint __GeometryCollection = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}