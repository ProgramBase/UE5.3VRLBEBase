using Script.CoreUObject;
using Script.MetasoundEngine;
using Script.Library;

namespace Script.MetasoundEditor
{
	[PathName("/Script/MetasoundEditor.MetasoundEditorGraph")]
	public partial class UMetasoundEditorGraph : UMetasoundEditorGraphBase, IStaticClass
	{
		public TArray<UMetasoundEditorGraphInput> Inputs
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Inputs, __ReturnBuffer);

					return *(TArray<UMetasoundEditorGraphInput>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Inputs, __InBuffer);
				}
			}
		}

		public TArray<UMetasoundEditorGraphOutput> Outputs
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Outputs, __ReturnBuffer);

					return *(TArray<UMetasoundEditorGraphOutput>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Outputs, __InBuffer);
				}
			}
		}

		public TArray<UMetasoundEditorGraphVariable> Variables
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Variables, __ReturnBuffer);

					return *(TArray<UMetasoundEditorGraphVariable>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Variables, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MetasoundEditor.MetasoundEditorGraph");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Inputs = 0;

		private static uint __Outputs = 0;

		private static uint __Variables = 0;
	}
}