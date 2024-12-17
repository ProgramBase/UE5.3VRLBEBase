using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.BehaviorTreeEditor
{
	[PathName("/Script/BehaviorTreeEditor.BehaviorTreeSchemaAction_AutoArrange")]
	public partial class FBehaviorTreeSchemaAction_AutoArrange : FEdGraphSchemaAction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/BehaviorTreeEditor.BehaviorTreeSchemaAction_AutoArrange");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FBehaviorTreeSchemaAction_AutoArrange()
		{
		}

		public static bool operator ==(FBehaviorTreeSchemaAction_AutoArrange A, FBehaviorTreeSchemaAction_AutoArrange B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FBehaviorTreeSchemaAction_AutoArrange A, FBehaviorTreeSchemaAction_AutoArrange B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FBehaviorTreeSchemaAction_AutoArrange;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}