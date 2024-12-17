using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.PhysicsConvexData")]
	public partial class FPhysicsConvexData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MeshModelingToolsExp.PhysicsConvexData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPhysicsConvexData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPhysicsConvexData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPhysicsConvexData A, FPhysicsConvexData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPhysicsConvexData A, FPhysicsConvexData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPhysicsConvexData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int NumVertices
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NumVertices, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NumVertices, __InBuffer);
				}
			}
		}

		public int NumFaces
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NumFaces, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NumFaces, __InBuffer);
				}
			}
		}

		public FKShapeElem Element
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Element, __ReturnBuffer);

					return *(FKShapeElem*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Element, __InBuffer);
				}
			}
		}

		private static uint __NumVertices = 0;

		private static uint __NumFaces = 0;

		private static uint __Element = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}