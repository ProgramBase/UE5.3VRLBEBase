using Script.CoreUObject;
using Script.Library;

namespace Script.EditorConfig
{
	[PathName("/Script/EditorConfig.EditorConfigTestComplexArray")]
	public partial class FEditorConfigTestComplexArray : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/EditorConfig.EditorConfigTestComplexArray");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FEditorConfigTestComplexArray() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FEditorConfigTestComplexArray() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FEditorConfigTestComplexArray A, FEditorConfigTestComplexArray B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FEditorConfigTestComplexArray A, FEditorConfigTestComplexArray B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FEditorConfigTestComplexArray;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FEditorConfigTestKey> Array
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Array, __ReturnBuffer);

					return *(TArray<FEditorConfigTestKey>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Array, __InBuffer);
				}
			}
		}

		private static uint __Array = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}