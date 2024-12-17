using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AudioEditor
{
	[PathName("/Script/AudioEditor.SoundCueGraphSchemaAction_NewNode")]
	public partial class FSoundCueGraphSchemaAction_NewNode : FEdGraphSchemaAction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AudioEditor.SoundCueGraphSchemaAction_NewNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSoundCueGraphSchemaAction_NewNode()
		{
		}

		public static bool operator ==(FSoundCueGraphSchemaAction_NewNode A, FSoundCueGraphSchemaAction_NewNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSoundCueGraphSchemaAction_NewNode A, FSoundCueGraphSchemaAction_NewNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSoundCueGraphSchemaAction_NewNode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TSubclassOf<USoundNode> SoundNodeClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SoundNodeClass, __ReturnBuffer);

					return *(TSubclassOf<USoundNode>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SoundNodeClass, __InBuffer);
				}
			}
		}

		private static uint __SoundNodeClass = 0;

	}
}