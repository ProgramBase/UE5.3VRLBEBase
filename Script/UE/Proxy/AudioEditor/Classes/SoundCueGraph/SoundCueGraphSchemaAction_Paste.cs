using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AudioEditor
{
	[PathName("/Script/AudioEditor.SoundCueGraphSchemaAction_Paste")]
	public partial class FSoundCueGraphSchemaAction_Paste : FEdGraphSchemaAction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AudioEditor.SoundCueGraphSchemaAction_Paste");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSoundCueGraphSchemaAction_Paste()
		{
		}

		public static bool operator ==(FSoundCueGraphSchemaAction_Paste A, FSoundCueGraphSchemaAction_Paste B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSoundCueGraphSchemaAction_Paste A, FSoundCueGraphSchemaAction_Paste B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSoundCueGraphSchemaAction_Paste;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}