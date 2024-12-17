using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.EditorImportWorkflowDefinition")]
	public partial class FEditorImportWorkflowDefinition : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.EditorImportWorkflowDefinition");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FEditorImportWorkflowDefinition() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FEditorImportWorkflowDefinition() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FEditorImportWorkflowDefinition A, FEditorImportWorkflowDefinition B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FEditorImportWorkflowDefinition A, FEditorImportWorkflowDefinition B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FEditorImportWorkflowDefinition;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FFilePath ImportFilePath
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ImportFilePath, __ReturnBuffer);

					return *(FFilePath*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ImportFilePath, __InBuffer);
				}
			}
		}

		public TArray<FImportFactorySettingValues> FactorySettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FactorySettings, __ReturnBuffer);

					return *(TArray<FImportFactorySettingValues>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FactorySettings, __InBuffer);
				}
			}
		}

		private static uint __ImportFilePath = 0;

		private static uint __FactorySettings = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}