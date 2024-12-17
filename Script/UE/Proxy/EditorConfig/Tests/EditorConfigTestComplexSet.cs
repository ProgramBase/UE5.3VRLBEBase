using Script.CoreUObject;
using Script.Library;

namespace Script.EditorConfig
{
	[PathName("/Script/EditorConfig.EditorConfigTestComplexSet")]
	public partial class FEditorConfigTestComplexSet : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/EditorConfig.EditorConfigTestComplexSet");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FEditorConfigTestComplexSet() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FEditorConfigTestComplexSet() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FEditorConfigTestComplexSet A, FEditorConfigTestComplexSet B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FEditorConfigTestComplexSet A, FEditorConfigTestComplexSet B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FEditorConfigTestComplexSet;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TSet<FEditorConfigTestKey> Set
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Set, __ReturnBuffer);

					return *(TSet<FEditorConfigTestKey>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Set, __InBuffer);
				}
			}
		}

		private static uint __Set = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}