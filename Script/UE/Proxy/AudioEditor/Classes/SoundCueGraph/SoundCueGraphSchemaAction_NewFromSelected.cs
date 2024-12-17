using Script.CoreUObject;
using Script.Library;

namespace Script.AudioEditor
{
	[PathName("/Script/AudioEditor.SoundCueGraphSchemaAction_NewFromSelected")]
	public partial class FSoundCueGraphSchemaAction_NewFromSelected : FSoundCueGraphSchemaAction_NewNode, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AudioEditor.SoundCueGraphSchemaAction_NewFromSelected");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSoundCueGraphSchemaAction_NewFromSelected()
		{
		}

		public static bool operator ==(FSoundCueGraphSchemaAction_NewFromSelected A, FSoundCueGraphSchemaAction_NewFromSelected B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSoundCueGraphSchemaAction_NewFromSelected A, FSoundCueGraphSchemaAction_NewFromSelected B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSoundCueGraphSchemaAction_NewFromSelected;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}