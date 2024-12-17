using Script.CoreUObject;
using Script.Library;

namespace Script.EditorScriptingUtilities
{
	[PathName("/Script/EditorScriptingUtilities.EditorDialogLibraryObjectDetailsViewOptions")]
	public partial class FEditorDialogLibraryObjectDetailsViewOptions : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/EditorScriptingUtilities.EditorDialogLibraryObjectDetailsViewOptions");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FEditorDialogLibraryObjectDetailsViewOptions() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FEditorDialogLibraryObjectDetailsViewOptions() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FEditorDialogLibraryObjectDetailsViewOptions A, FEditorDialogLibraryObjectDetailsViewOptions B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FEditorDialogLibraryObjectDetailsViewOptions A, FEditorDialogLibraryObjectDetailsViewOptions B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FEditorDialogLibraryObjectDetailsViewOptions;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bShowObjectName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bShowObjectName, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bShowObjectName, __InBuffer);
				}
			}
		}

		public bool bAllowSearch
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bAllowSearch, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bAllowSearch, __InBuffer);
				}
			}
		}

		public int MinWidth
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MinWidth, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MinWidth, __InBuffer);
				}
			}
		}

		public int MinHeight
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MinHeight, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MinHeight, __InBuffer);
				}
			}
		}

		public float ValueColumnWidthRatio
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ValueColumnWidthRatio, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ValueColumnWidthRatio, __InBuffer);
				}
			}
		}

		private static uint __bShowObjectName = 0;

		private static uint __bAllowSearch = 0;

		private static uint __MinWidth = 0;

		private static uint __MinHeight = 0;

		private static uint __ValueColumnWidthRatio = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}