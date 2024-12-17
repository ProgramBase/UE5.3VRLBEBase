using Script.CoreUObject;
using Script.Library;

namespace Script.MetasoundEditor
{
	[PathName("/Script/MetasoundEditor.MetasoundEditorGraphMemberDefaultObjectRef")]
	public partial class FMetasoundEditorGraphMemberDefaultObjectRef : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MetasoundEditor.MetasoundEditorGraphMemberDefaultObjectRef");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMetasoundEditorGraphMemberDefaultObjectRef() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMetasoundEditorGraphMemberDefaultObjectRef() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMetasoundEditorGraphMemberDefaultObjectRef A, FMetasoundEditorGraphMemberDefaultObjectRef B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMetasoundEditorGraphMemberDefaultObjectRef A, FMetasoundEditorGraphMemberDefaultObjectRef B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMetasoundEditorGraphMemberDefaultObjectRef;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UObject Object
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Object, __ReturnBuffer);

					return *(UObject*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Object, __InBuffer);
				}
			}
		}

		private static uint __Object = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}