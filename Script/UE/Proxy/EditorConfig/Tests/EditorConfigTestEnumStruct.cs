using Script.CoreUObject;
using Script.Library;

namespace Script.EditorConfig
{
	[PathName("/Script/EditorConfig.EditorConfigTestEnumStruct")]
	public partial class FEditorConfigTestEnumStruct : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/EditorConfig.EditorConfigTestEnumStruct");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FEditorConfigTestEnumStruct() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FEditorConfigTestEnumStruct() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FEditorConfigTestEnumStruct A, FEditorConfigTestEnumStruct B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FEditorConfigTestEnumStruct A, FEditorConfigTestEnumStruct B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FEditorConfigTestEnumStruct;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int Before
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Before, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Before, __InBuffer);
				}
			}
		}

		public EEditorConfigTestEnum Enum
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Enum, __ReturnBuffer);

					return *(EEditorConfigTestEnum*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Enum, __InBuffer);
				}
			}
		}

		public int After
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __After, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __After, __InBuffer);
				}
			}
		}

		private static uint __Before = 0;

		private static uint __Enum = 0;

		private static uint __After = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}