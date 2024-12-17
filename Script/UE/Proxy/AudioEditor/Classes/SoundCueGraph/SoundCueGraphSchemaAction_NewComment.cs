using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AudioEditor
{
	[PathName("/Script/AudioEditor.SoundCueGraphSchemaAction_NewComment")]
	public partial class FSoundCueGraphSchemaAction_NewComment : FEdGraphSchemaAction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AudioEditor.SoundCueGraphSchemaAction_NewComment");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSoundCueGraphSchemaAction_NewComment()
		{
		}

		public static bool operator ==(FSoundCueGraphSchemaAction_NewComment A, FSoundCueGraphSchemaAction_NewComment B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSoundCueGraphSchemaAction_NewComment A, FSoundCueGraphSchemaAction_NewComment B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSoundCueGraphSchemaAction_NewComment;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}