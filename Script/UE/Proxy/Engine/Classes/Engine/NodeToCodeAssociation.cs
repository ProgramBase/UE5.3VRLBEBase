using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.NodeToCodeAssociation")]
	public partial class FNodeToCodeAssociation : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.NodeToCodeAssociation");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNodeToCodeAssociation() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNodeToCodeAssociation() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNodeToCodeAssociation A, FNodeToCodeAssociation B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNodeToCodeAssociation A, FNodeToCodeAssociation B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNodeToCodeAssociation;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}