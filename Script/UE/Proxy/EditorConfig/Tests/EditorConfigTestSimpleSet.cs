using Script.CoreUObject;
using Script.Library;

namespace Script.EditorConfig
{
	[PathName("/Script/EditorConfig.EditorConfigTestSimpleSet")]
	public partial class FEditorConfigTestSimpleSet : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/EditorConfig.EditorConfigTestSimpleSet");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FEditorConfigTestSimpleSet() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FEditorConfigTestSimpleSet() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FEditorConfigTestSimpleSet A, FEditorConfigTestSimpleSet B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FEditorConfigTestSimpleSet A, FEditorConfigTestSimpleSet B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FEditorConfigTestSimpleSet;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TSet<FName> Set
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Set, __ReturnBuffer);

					return *(TSet<FName>*)__ReturnBuffer;
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