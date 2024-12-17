using Script.CoreUObject;
using Script.Library;

namespace Script.MetasoundEditor
{
	[PathName("/Script/MetasoundEditor.MetasoundEditorGraphMemberDefaultBoolRef")]
	public partial class FMetasoundEditorGraphMemberDefaultBoolRef : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MetasoundEditor.MetasoundEditorGraphMemberDefaultBoolRef");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMetasoundEditorGraphMemberDefaultBoolRef() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMetasoundEditorGraphMemberDefaultBoolRef() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMetasoundEditorGraphMemberDefaultBoolRef A, FMetasoundEditorGraphMemberDefaultBoolRef B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMetasoundEditorGraphMemberDefaultBoolRef A, FMetasoundEditorGraphMemberDefaultBoolRef B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMetasoundEditorGraphMemberDefaultBoolRef;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool Value
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Value, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Value, __InBuffer);
				}
			}
		}

		private static uint __Value = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}