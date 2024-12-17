using Script.CoreUObject;
using Script.Library;

namespace Script.GeometryCollectionEngine
{
	[PathName("/Script/GeometryCollectionEngine.GeometryCollectionDebugDrawWarningMessage")]
	public partial class FGeometryCollectionDebugDrawWarningMessage : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GeometryCollectionEngine.GeometryCollectionDebugDrawWarningMessage");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGeometryCollectionDebugDrawWarningMessage() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FGeometryCollectionDebugDrawWarningMessage() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FGeometryCollectionDebugDrawWarningMessage A, FGeometryCollectionDebugDrawWarningMessage B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGeometryCollectionDebugDrawWarningMessage A, FGeometryCollectionDebugDrawWarningMessage B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGeometryCollectionDebugDrawWarningMessage;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}