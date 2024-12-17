using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.PhysicsLevelSetData")]
	public partial class FPhysicsLevelSetData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MeshModelingToolsExp.PhysicsLevelSetData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPhysicsLevelSetData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPhysicsLevelSetData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPhysicsLevelSetData A, FPhysicsLevelSetData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPhysicsLevelSetData A, FPhysicsLevelSetData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPhysicsLevelSetData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

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

		private static uint __Element = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}