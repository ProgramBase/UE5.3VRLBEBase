using Script.CoreUObject;
using Script.Library;

namespace Script.EditorScriptingUtilities
{
	[PathName("/Script/EditorScriptingUtilities.EditorScriptingMeshReductionOptions_Deprecated")]
	public partial class FEditorScriptingMeshReductionOptions_Deprecated : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/EditorScriptingUtilities.EditorScriptingMeshReductionOptions_Deprecated");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FEditorScriptingMeshReductionOptions_Deprecated() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FEditorScriptingMeshReductionOptions_Deprecated() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FEditorScriptingMeshReductionOptions_Deprecated A, FEditorScriptingMeshReductionOptions_Deprecated B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FEditorScriptingMeshReductionOptions_Deprecated A, FEditorScriptingMeshReductionOptions_Deprecated B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FEditorScriptingMeshReductionOptions_Deprecated;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bAutoComputeLODScreenSize
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bAutoComputeLODScreenSize, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bAutoComputeLODScreenSize, __InBuffer);
				}
			}
		}

		public TArray<FEditorScriptingMeshReductionSettings_Deprecated> ReductionSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ReductionSettings, __ReturnBuffer);

					return *(TArray<FEditorScriptingMeshReductionSettings_Deprecated>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ReductionSettings, __InBuffer);
				}
			}
		}

		private static uint __bAutoComputeLODScreenSize = 0;

		private static uint __ReductionSettings = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}