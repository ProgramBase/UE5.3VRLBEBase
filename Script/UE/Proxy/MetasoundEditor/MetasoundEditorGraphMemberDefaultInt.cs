using Script.CoreUObject;
using Script.Library;

namespace Script.MetasoundEditor
{
	[PathName("/Script/MetasoundEditor.MetasoundEditorGraphMemberDefaultInt")]
	public partial class UMetasoundEditorGraphMemberDefaultInt : UMetasoundEditorGraphMemberDefaultLiteral, IStaticClass
	{
		public FMetasoundEditorGraphMemberDefaultIntRef Default
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Default, __ReturnBuffer);

					return *(FMetasoundEditorGraphMemberDefaultIntRef*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Default, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MetasoundEditor.MetasoundEditorGraphMemberDefaultInt");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Default = 0;
	}
}