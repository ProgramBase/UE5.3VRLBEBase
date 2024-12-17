using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AudioEditor
{
	[PathName("/Script/AudioEditor.SoundClassGraphSchemaAction_NewNode")]
	public partial class FSoundClassGraphSchemaAction_NewNode : FEdGraphSchemaAction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AudioEditor.SoundClassGraphSchemaAction_NewNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSoundClassGraphSchemaAction_NewNode()
		{
		}

		public static bool operator ==(FSoundClassGraphSchemaAction_NewNode A, FSoundClassGraphSchemaAction_NewNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSoundClassGraphSchemaAction_NewNode A, FSoundClassGraphSchemaAction_NewNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSoundClassGraphSchemaAction_NewNode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}