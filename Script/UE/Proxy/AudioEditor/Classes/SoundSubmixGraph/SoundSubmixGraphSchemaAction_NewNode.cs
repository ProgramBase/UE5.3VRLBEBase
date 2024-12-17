using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AudioEditor
{
	[PathName("/Script/AudioEditor.SoundSubmixGraphSchemaAction_NewNode")]
	public partial class FSoundSubmixGraphSchemaAction_NewNode : FEdGraphSchemaAction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AudioEditor.SoundSubmixGraphSchemaAction_NewNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSoundSubmixGraphSchemaAction_NewNode()
		{
		}

		public static bool operator ==(FSoundSubmixGraphSchemaAction_NewNode A, FSoundSubmixGraphSchemaAction_NewNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSoundSubmixGraphSchemaAction_NewNode A, FSoundSubmixGraphSchemaAction_NewNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSoundSubmixGraphSchemaAction_NewNode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}