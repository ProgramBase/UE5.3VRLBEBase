using Script.CoreUObject;
using Script.Library;

namespace Script.EditorScriptingUtilities
{
	[PathName("/Script/EditorScriptingUtilities.EditorScriptingMeshReductionSettings_Deprecated")]
	public partial class FEditorScriptingMeshReductionSettings_Deprecated : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/EditorScriptingUtilities.EditorScriptingMeshReductionSettings_Deprecated");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FEditorScriptingMeshReductionSettings_Deprecated() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FEditorScriptingMeshReductionSettings_Deprecated() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FEditorScriptingMeshReductionSettings_Deprecated A, FEditorScriptingMeshReductionSettings_Deprecated B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FEditorScriptingMeshReductionSettings_Deprecated A, FEditorScriptingMeshReductionSettings_Deprecated B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FEditorScriptingMeshReductionSettings_Deprecated;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float PercentTriangles
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PercentTriangles, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PercentTriangles, __InBuffer);
				}
			}
		}

		public float ScreenSize
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ScreenSize, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ScreenSize, __InBuffer);
				}
			}
		}

		private static uint __PercentTriangles = 0;

		private static uint __ScreenSize = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}