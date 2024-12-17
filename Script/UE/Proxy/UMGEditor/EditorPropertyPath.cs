using Script.CoreUObject;
using Script.Library;

namespace Script.UMGEditor
{
	[PathName("/Script/UMGEditor.EditorPropertyPath")]
	public partial class FEditorPropertyPath : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/UMGEditor.EditorPropertyPath");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FEditorPropertyPath() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FEditorPropertyPath() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FEditorPropertyPath A, FEditorPropertyPath B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FEditorPropertyPath A, FEditorPropertyPath B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FEditorPropertyPath;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FEditorPropertyPathSegment> Segments
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Segments, __ReturnBuffer);

					return *(TArray<FEditorPropertyPathSegment>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Segments, __InBuffer);
				}
			}
		}

		private static uint __Segments = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}