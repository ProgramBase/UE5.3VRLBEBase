using Script.CoreUObject;
using Script.Library;

namespace Script.EditorConfig
{
	[PathName("/Script/EditorConfig.EditorConfigTestSimpleMap")]
	public partial class FEditorConfigTestSimpleMap : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/EditorConfig.EditorConfigTestSimpleMap");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FEditorConfigTestSimpleMap() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FEditorConfigTestSimpleMap() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FEditorConfigTestSimpleMap A, FEditorConfigTestSimpleMap B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FEditorConfigTestSimpleMap A, FEditorConfigTestSimpleMap B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FEditorConfigTestSimpleMap;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TMap<FString, FString> Map
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Map, __ReturnBuffer);

					return *(TMap<FString, FString>*)__ReturnBuffer;
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