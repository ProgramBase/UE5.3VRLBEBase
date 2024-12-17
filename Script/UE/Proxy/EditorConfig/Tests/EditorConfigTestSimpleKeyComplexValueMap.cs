using Script.CoreUObject;
using Script.Library;

namespace Script.EditorConfig
{
	[PathName("/Script/EditorConfig.EditorConfigTestSimpleKeyComplexValueMap")]
	public partial class FEditorConfigTestSimpleKeyComplexValueMap : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/EditorConfig.EditorConfigTestSimpleKeyComplexValueMap");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FEditorConfigTestSimpleKeyComplexValueMap() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FEditorConfigTestSimpleKeyComplexValueMap() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FEditorConfigTestSimpleKeyComplexValueMap A, FEditorConfigTestSimpleKeyComplexValueMap B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FEditorConfigTestSimpleKeyComplexValueMap A, FEditorConfigTestSimpleKeyComplexValueMap B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FEditorConfigTestSimpleKeyComplexValueMap;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TMap<FString, FEditorConfigTestKey> Map
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Map, __ReturnBuffer);

					return *(TMap<FString, FEditorConfigTestKey>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Map, __InBuffer);
				}
			}
		}

		private static uint __Map = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}